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

namespace CBCTLabeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                itk.simple.Image image = reader.Execute();

                VectorUInt32 size = image.GetSize();
                Console.WriteLine("Image size: " + size[0] + " " + size[1] + " " + size[2]);

                int length = (int)size[0] * (int)size[1] * (int)size[2];
                Int32 [] dicom_array = new Int32[length];
                Marshal.Copy(image.GetBufferAsInt32(), dicom_array, 0, length);

                double min_window = (double)window_center - 0.5 * (double)window_width;
                for (int i = 0; i < length; i++)
                {
                    double temp = (dicom_array[i] - min_window) / (double)window_width;
                    if (temp < 0)
                    {
                        temp = 0;
                    }
                    if (temp > 1)
                    {
                        temp = 1;
                    }
                    dicom_array[i] = (int)(temp * 255);
                }

                dicom_array_3d = new int[(int)size[2], (int)size[0], (int)size[1]];
                Buffer.BlockCopy(dicom_array, 0, dicom_array_3d, 0, length * 4);
                dicom_array = null;
                GC.Collect();

                numLabel.Text = "of " + ((int)size[2]).ToString() + " slices";
                num = 1;
                imageNumber = (int)size[2];
                trackBar.Minimum = 1;
                trackBar.Maximum = imageNumber;
                numbertextBox.Text = num.ToString();
                labeling = false;
                labeled = false;

                ShowImage();

            }
            GC.Collect();
        }


        private void CloseFile_Click(object sender, EventArgs e)
        {
            dicom_array_3d = null;
            num = 0;
            imageNumber = 0;
            numLabel.Text = "of 0 slices";
            trackBar.Minimum = 0;
            trackBar.Maximum = 0;
            pictureBox.Image = null;
            numbertextBox.Text = null;
            labeled = false;
            GC.Collect();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK && labeled)
            {
                String filePath = saveFileDialog.FileName;

                int labeledx = num - 1;
                if (labeledx < 48)
                {
                    labeledx = 48;
                }
                if (labeledx > imageNumber - 49)
                {
                    labeledx = imageNumber - 49;
                }

                Dictionary<string, int> dict = new Dictionary<string, int>();
                dict.Add("midx", labeledx);
                dict.Add("midy", labelPositionX);
                dict.Add("midz", labelPositionY);
                string jsonOutput = JsonConvert.SerializeObject(dict);
                System.IO.File.WriteAllText(filePath, jsonOutput);
            }
        }

        private void ShowImage()
        {
            Bitmap bitdata = new Bitmap(512, 512);
            for (int x = 0; x < 512; x++)
            {
                for (int y = 0; y < 512; y++)
                {
                    Color c = Color.FromArgb(dicom_array_3d[num - 1, x, y], 
                        dicom_array_3d[num - 1, x, y], 
                        dicom_array_3d[num - 1, x, y]);
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
                    Color c = Color.FromArgb(dicom_array_3d[num - 1, x, y], 
                        dicom_array_3d[num - 1, x, y], 
                        dicom_array_3d[num - 1, x, y]);
                    bitdata.SetPixel(y, x, c);
                }
            }

            for (int x = labelPositionX - 48; x < labelPositionX + 48; x++)
            {
                for (int y = labelPositionY - 48; y < labelPositionY + 48; y++)
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
            if(num > 1)
            {
                num -= 1;
                numbertextBox.Text = num.ToString();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (dicom_array_3d == null)
            {
                return;
            }
            if (num < imageNumber)
            {
                num += 1;
                numbertextBox.Text = num.ToString();
            }
        }

        private void serieLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numbertextBox.Text = trackBar.Value.ToString();
        }

        private void numbertextBox_TextChanged(object sender, EventArgs e)
        {
            if (dicom_array_3d == null || numbertextBox.Text == "")
            {
                return;
            }
            int changed_number = int.Parse(numbertextBox.Text);
            if (changed_number < 1)
            {
                numbertextBox.Text = 1.ToString();
                return;
            }
            if (changed_number > imageNumber)
            {
                numbertextBox.Text = imageNumber.ToString();
                return;
            }
            labeled = false;

            num = changed_number;
            ShowImage();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (labeling)
            {
                Cursor = Cursors.Default;
                int positionX = Cursor.Position.X - pictureBox.PointToScreen(new Point(0, 0)).X;
                int positionY = Cursor.Position.Y - pictureBox.PointToScreen(new Point(0, 0)).Y;

                if (positionX < 48)
                {
                    positionX = 48;
                }
                if (positionX > 511 - 48)
                {
                    positionX = 511 - 48;
                }
                if (positionY < 48)
                {
                    positionY = 48;
                }
                if (positionY > 511 - 48)
                {
                    positionY = 511 - 48;
                }
                labelPositionX = positionX;
                labelPositionY = positionY;

                ShowLabeledImage();
                labeling = false;
                labeled = true;
            }
        }
    }
}
