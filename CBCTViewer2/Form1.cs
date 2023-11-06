using itk.simple;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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

                numLabel.Text = "of " + (size[2] - 1).ToString() + " slices";
                imageNumber = (int)size[2] - 1;
                trackBar.Minimum = 0;
                trackBar.Maximum = imageNumber;
                labeling = false;
                labeled = false;

                ShowImage();

            }
        }

        private void ShowImage()
        {
            Bitmap bitdata = new Bitmap(512, 512); //创建原图大小的空白位图
            for (int x = 0; x < 512; x++)
            {
                for (int y = 0; y < 512; y++)
                {
                    Color c = Color.FromArgb(dicom_array_3d[num, x, y], dicom_array_3d[num, x, y], dicom_array_3d[num, x, y]);
                    bitdata.SetPixel(y, x, c);
                }
            }

            System.Drawing.Image img = System.Drawing.Image.FromHbitmap(bitdata.GetHbitmap());
            pictureBox.Image = img;
            pictureBox.Show();
        }

        private void CloseFile_Click(object sender, EventArgs e)
        {
            if (labeled)
            {
                imageNumber = 0;
                numLabel.Text = "of 0 slices";
                trackBar.Maximum = 0;
                pictureBox.Image = global::CBCTLabeler.Properties.Resources.background;
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (savefolderDialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = savefolderDialog.SelectedPath;

                Console.WriteLine("Writing image: " + filePath);
                ImageFileWriter writer = new ImageFileWriter();
                writer.SetFileName(filePath);
                // writer.Execute(image);
            }
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

        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            if(num < imageNumber && num > 0)
            {
                num -= 1;
                numbertextBox.Text = num.ToString();
                ShowImage();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (num < imageNumber)
            {
                num += 1;
                numbertextBox.Text = num.ToString();
                ShowImage();
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
            num = int.Parse(numbertextBox.Text);
            if (num >= 0 && num < imageNumber)
            {
                ShowImage();
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
