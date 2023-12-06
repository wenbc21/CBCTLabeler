using itk.simple;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Newtonsoft.Json.Linq;

namespace CBCTLabeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (openfolderDialog.ShowDialog() == DialogResult.OK)
            {
                dicom_array_3d = null;
                GC.Collect();
                String filePath = openfolderDialog.SelectedPath;

                ImageSeriesReader reader = new ImageSeriesReader();
                VectorString dicom_names = ImageSeriesReader.GetGDCMSeriesFileNames(filePath);
                reader.SetFileNames(dicom_names);
                itk.simple.Image image;
                try
                {
                    image = reader.Execute();
                }
                catch
                {
                    MessageBox.Show("路径下没有CBCT文件！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                image = reader.Execute();
                VectorUInt32 size = image.GetSize();

                int length = (int)size[0] * (int)size[1] * (int)size[2];
                Int32[] dicom_array = new Int32[length];
                Marshal.Copy(image.GetBufferAsInt32(), dicom_array, 0, length);

                double minWindow = windowCenter - 0.5 * windowWidth;
                for (int i = 0; i < length; i++)
                {
                    double temp = (dicom_array[i] - minWindow) / windowWidth;
                    temp = (temp < 0) ? 0 : (temp > 1) ? 1 : temp;
                    dicom_array[i] = (int)(temp * 255);
                }

                dicom_array_3d = new int[(int)size[2], (int)size[0], (int)size[1]];
                Buffer.BlockCopy(dicom_array, 0, dicom_array_3d, 0, length * 4);
                dicom_array = null;
                GC.Collect();

                totalNum = (int)size[2];
                numLabel.Text = "of " + totalNum.ToString() + " slices";
                currectNum = 1;
                trackBar.Minimum = 1;
                trackBar.Maximum = totalNum;
                numbertextBox.Text = currectNum.ToString();
                labeling = false;
                labeled = false;
                fileLabel.Text = "File Path: " + filePath;
                sizeLabel.Text = "Size: \n" + totalNum.ToString() + ", 512, 512";
                positionLabel.Text = "Label Position:";

                ShowImage();
            }
            GC.Collect();
        }

        private void CloseFile_Click(object sender, EventArgs e)
        {
            dicom_array_3d = null;
            currectNum = 0;
            totalNum = 0;
            numLabel.Text = "of 0 slices";
            trackBar.Minimum = 0;
            trackBar.Maximum = 0;
            pictureBox.Image = global::CBCTVLabeler.Properties.Resources.background;
            numbertextBox.Text = null;
            labeled = false;
            fileLabel.Text = "File Path:";
            sizeLabel.Text = "Size:";
            positionLabel.Text = "Label Position:";
            GC.Collect();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (!labeled)
            {
                MessageBox.Show("还没有进行标注！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = saveFileDialog.FileName;

                Dictionary<string, int> dict = new Dictionary<string, int>();
                dict.Add("midx", labelPositionX);
                dict.Add("midy", labelPositionY);
                dict.Add("midz", labelPositionZ);
                string jsonOutput = JsonConvert.SerializeObject(dict);
                System.IO.File.WriteAllText(filePath + ".json", jsonOutput);

                Int32[] dicom_labeled = new Int32[96*96*96];
                for(int i = 0; i < 96; i++)
                {
                    for(int j = 0; j < 96; j++)
                    {
                        for(int k = 0; k < 96; k++)
                        {
                            dicom_labeled[i * 96 * 96 + j * 96 + k] = (Int32)dicom_array_3d[
                                labelPositionX - 48 + i,
                                labelPositionZ - 48 + j,
                                labelPositionY - 48 + k];
                        }
                    }
                }
                itk.simple.Image outImage = new itk.simple.Image(96, 96, 96, itk.simple.PixelIDValueEnum.sitkInt32);
                IntPtr outImageBuffer = outImage.GetBufferAsInt32();
                Marshal.Copy(dicom_labeled, 0, outImageBuffer, 96 * 96 * 96);
                SimpleITK.WriteImage(outImage, filePath + ".nii.gz");

                MessageBox.Show("保存成功！", "注意", MessageBoxButtons.OK);
            }
        }

        private void ShowImage()
        {
            Bitmap bitdata = new Bitmap(512, 512);
            for (int x = 0; x < 512; x++)
            {
                for (int y = 0; y < 512; y++)
                {
                    Color c = Color.FromArgb(dicom_array_3d[currectNum - 1, x, y], 
                        dicom_array_3d[currectNum - 1, x, y], 
                        dicom_array_3d[currectNum - 1, x, y]);
                    bitdata.SetPixel(y, x, c);
                }
            }

            pictureBox.Image = System.Drawing.Image.FromHbitmap(bitdata.GetHbitmap());
            pictureBox.Show();
            
        }

        private void ShowLabeledImage()
        {
            Bitmap bitdata = new Bitmap(512, 512);
            for (int x = 0; x < 512; x++)
            {
                for (int y = 0; y < 512; y++)
                {
                    Color c = Color.FromArgb(dicom_array_3d[currectNum - 1, x, y], 
                        dicom_array_3d[currectNum - 1, x, y], 
                        dicom_array_3d[currectNum - 1, x, y]);
                    bitdata.SetPixel(y, x, c);
                }
            }

            for (int x = labelPositionY - 48; x < labelPositionY + 48; x++)
            {
                for (int y = labelPositionZ - 48; y < labelPositionZ + 48; y++)
                {
                    Color pixel = bitdata.GetPixel(x, y);
                    Color c = Color.FromArgb((pixel.R * 2 + labelColor.R) / 3,
                        (pixel.G * 2 + labelColor.G) / 3, 
                        (pixel.B * 2 + labelColor.B) / 3);
                    bitdata.SetPixel(x, y, c);
                }
            }

            pictureBox.Image = System.Drawing.Image.FromHbitmap(bitdata.GetHbitmap());
            pictureBox.Show();
        }

        private void zoominButton_Click(object sender, EventArgs e)
        {
        }

        private void zoomoutButton_Click(object sender, EventArgs e)
        {
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                labelColor = colorDialog.Color;
            }
        }

        private void labelButton_Click(object sender, EventArgs e)
        {
            if (dicom_array_3d == null)
            {
                return;
            }
            labeling = true;
            Cursor = Cursors.Cross;
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            if (dicom_array_3d == null)
            {
                return;
            }
            if(currectNum > 1)
            {
                currectNum -= 1;
                numbertextBox.Text = currectNum.ToString();
            }
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (dicom_array_3d == null)
            {
                return;
            }
            if (currectNum < totalNum)
            {
                currectNum += 1;
                numbertextBox.Text = currectNum.ToString();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numbertextBox.Text = trackBar.Value.ToString();
        }

        private void numbertextBox_TextChanged(object sender, EventArgs e)
        {
            if (dicom_array_3d == null || !int.TryParse(numbertextBox.Text, out currectNum))
            {
                return;
            }
            int changedNumber = int.Parse(numbertextBox.Text);
            if (changedNumber < 1)
            {
                numbertextBox.Text = 1.ToString();
                return;
            }
            if (changedNumber > totalNum)
            {
                numbertextBox.Text = totalNum.ToString();
                return;
            }
            labeled = false;

            currectNum = changedNumber;
            ShowImage();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (labeling)
            {
                Cursor = Cursors.Default;
                int positionY = Cursor.Position.X - pictureBox.PointToScreen(new Point(0, 0)).X;
                int positionZ = Cursor.Position.Y - pictureBox.PointToScreen(new Point(0, 0)).Y;

                labelPositionX = currectNum - 1;
                labelPositionX = (labelPositionX < 48) ? 48 : (labelPositionX > totalNum - 49) ? totalNum - 49 : labelPositionX;
                labelPositionY = (positionY < 48) ? 48 : (positionY > 511 - 48) ? 511 - 48 : positionY;
                labelPositionZ = (positionZ < 48) ? 48 : (positionZ > 511 - 48) ? 511 - 48 : positionZ;

                ShowLabeledImage();
                labeling = false;
                labeled = true;
                positionLabel.Text = "Label Position: \n" + labelPositionX.ToString() + ", " +
                    labelPositionY.ToString() + ", " +  labelPositionZ.ToString();
            }
        }
    }
}
