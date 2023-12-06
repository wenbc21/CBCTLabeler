using System.Drawing;

namespace CBCTLabeler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.zoominButton = new System.Windows.Forms.Button();
            this.zoomoutButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.labelButton = new System.Windows.Forms.Button();
            this.serieLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lastButton = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.nextButton = new System.Windows.Forms.Button();
            this.numbertextBox = new System.Windows.Forms.TextBox();
            this.numLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.fileLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OpenFile = new System.Windows.Forms.Button();
            this.CloseFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.cursorLabel = new System.Windows.Forms.Label();
            this.openfolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.imageLayoutPanel.SuspendLayout();
            this.serieLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.fileLayoutPanel.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 698F));
            this.tableLayoutPanel1.Controls.Add(this.imageLayoutPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.serieLayoutPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fileLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(818, 700);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imageLayoutPanel
            // 
            this.imageLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageLayoutPanel.Controls.Add(this.zoominButton);
            this.imageLayoutPanel.Controls.Add(this.zoomoutButton);
            this.imageLayoutPanel.Controls.Add(this.colorButton);
            this.imageLayoutPanel.Controls.Add(this.labelButton);
            this.imageLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageLayoutPanel.Location = new System.Drawing.Point(3, 53);
            this.imageLayoutPanel.Name = "imageLayoutPanel";
            this.imageLayoutPanel.Size = new System.Drawing.Size(114, 194);
            this.imageLayoutPanel.TabIndex = 0;
            // 
            // zoominButton
            // 
            this.zoominButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoominButton.Location = new System.Drawing.Point(3, 3);
            this.zoominButton.Name = "zoominButton";
            this.zoominButton.Size = new System.Drawing.Size(100, 30);
            this.zoominButton.TabIndex = 0;
            this.zoominButton.Text = "ZoomIn";
            this.zoominButton.UseVisualStyleBackColor = true;
            this.zoominButton.Click += new System.EventHandler(this.zoominButton_Click);
            // 
            // zoomoutButton
            // 
            this.zoomoutButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomoutButton.Location = new System.Drawing.Point(3, 39);
            this.zoomoutButton.Name = "zoomoutButton";
            this.zoomoutButton.Size = new System.Drawing.Size(100, 30);
            this.zoomoutButton.TabIndex = 1;
            this.zoomoutButton.Text = "ZoomOut";
            this.zoomoutButton.UseVisualStyleBackColor = true;
            this.zoomoutButton.Click += new System.EventHandler(this.zoomoutButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorButton.Location = new System.Drawing.Point(3, 75);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(100, 30);
            this.colorButton.TabIndex = 2;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // labelButton
            // 
            this.labelButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButton.Location = new System.Drawing.Point(3, 111);
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(100, 30);
            this.labelButton.TabIndex = 3;
            this.labelButton.Text = "LABEL";
            this.labelButton.UseVisualStyleBackColor = true;
            this.labelButton.Click += new System.EventHandler(this.labelButton_Click);
            // 
            // serieLayoutPanel
            // 
            this.serieLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serieLayoutPanel.Controls.Add(this.lastButton);
            this.serieLayoutPanel.Controls.Add(this.trackBar);
            this.serieLayoutPanel.Controls.Add(this.nextButton);
            this.serieLayoutPanel.Controls.Add(this.numbertextBox);
            this.serieLayoutPanel.Controls.Add(this.numLabel);
            this.serieLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serieLayoutPanel.Location = new System.Drawing.Point(3, 253);
            this.serieLayoutPanel.Name = "serieLayoutPanel";
            this.serieLayoutPanel.Size = new System.Drawing.Size(114, 244);
            this.serieLayoutPanel.TabIndex = 0;
            // 
            // lastButton
            // 
            this.lastButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastButton.Location = new System.Drawing.Point(3, 3);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(100, 30);
            this.lastButton.TabIndex = 0;
            this.lastButton.Text = "Last";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(3, 39);
            this.trackBar.Maximum = 0;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(100, 56);
            this.trackBar.TabIndex = 3;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(3, 101);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 30);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // numbertextBox
            // 
            this.numbertextBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbertextBox.Location = new System.Drawing.Point(3, 137);
            this.numbertextBox.Name = "numbertextBox";
            this.numbertextBox.Size = new System.Drawing.Size(100, 25);
            this.numbertextBox.TabIndex = 2;
            this.numbertextBox.TextChanged += new System.EventHandler(this.numbertextBox_TextChanged);
            // 
            // numLabel
            // 
            this.numLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabel.Location = new System.Drawing.Point(3, 165);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(100, 30);
            this.numLabel.TabIndex = 4;
            this.numLabel.Text = "of 0 slices";
            this.numLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::CBCTVLabeler.Properties.Resources.background;
            this.pictureBox.Location = new System.Drawing.Point(123, 53);
            this.pictureBox.Name = "pictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox, 3);
            this.pictureBox.Size = new System.Drawing.Size(692, 644);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // fileLayoutPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.fileLayoutPanel, 2);
            this.fileLayoutPanel.Controls.Add(this.OpenFile);
            this.fileLayoutPanel.Controls.Add(this.CloseFile);
            this.fileLayoutPanel.Controls.Add(this.SaveFile);
            this.fileLayoutPanel.Controls.Add(this.fileLabel);
            this.fileLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.fileLayoutPanel.Name = "fileLayoutPanel";
            this.fileLayoutPanel.Size = new System.Drawing.Size(812, 44);
            this.fileLayoutPanel.TabIndex = 2;
            // 
            // OpenFile
            // 
            this.OpenFile.AutoSize = true;
            this.OpenFile.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile.Location = new System.Drawing.Point(3, 3);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(100, 30);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "OpenFile";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // CloseFile
            // 
            this.CloseFile.AutoSize = true;
            this.CloseFile.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseFile.Location = new System.Drawing.Point(109, 3);
            this.CloseFile.Name = "CloseFile";
            this.CloseFile.Size = new System.Drawing.Size(100, 30);
            this.CloseFile.TabIndex = 1;
            this.CloseFile.Text = "CloseFile";
            this.CloseFile.UseVisualStyleBackColor = true;
            this.CloseFile.Click += new System.EventHandler(this.CloseFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.AutoSize = true;
            this.SaveFile.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFile.Location = new System.Drawing.Point(215, 3);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(100, 30);
            this.SaveFile.TabIndex = 2;
            this.SaveFile.Text = "SaveFile";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.Location = new System.Drawing.Point(321, 3);
            this.fileLabel.Margin = new System.Windows.Forms.Padding(3);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(400, 30);
            this.fileLabel.TabIndex = 0;
            this.fileLabel.Text = "File Path:       ";
            this.fileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Controls.Add(this.sizeLabel);
            this.flowLayoutPanel.Controls.Add(this.positionLabel);
            this.flowLayoutPanel.Controls.Add(this.cursorLabel);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 503);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(114, 194);
            this.flowLayoutPanel.TabIndex = 4;
            // 
            // sizeLabel
            // 
            this.sizeLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.Location = new System.Drawing.Point(3, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(110, 50);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Size:       ";
            // 
            // positionLabel
            // 
            this.positionLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(3, 50);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(110, 50);
            this.positionLabel.TabIndex = 1;
            this.positionLabel.Text = "Label Position: ";
            // 
            // cursorLabel
            // 
            this.cursorLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursorLabel.Location = new System.Drawing.Point(3, 100);
            this.cursorLabel.Name = "cursorLabel";
            this.cursorLabel.Size = new System.Drawing.Size(120, 50);
            this.cursorLabel.TabIndex = 3;
            this.cursorLabel.Text = "Cursor Position:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "CBCTLabeler";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.imageLayoutPanel.ResumeLayout(false);
            this.serieLayoutPanel.ResumeLayout(false);
            this.serieLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.fileLayoutPanel.ResumeLayout(false);
            this.fileLayoutPanel.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel serieLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel fileLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel imageLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button zoominButton;
        private System.Windows.Forms.Button zoomoutButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button labelButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button CloseFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.FolderBrowserDialog openfolderDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox numbertextBox;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label cursorLabel;

        public int currectNum = 0;
        public int totalNum = 0;
        public int [ , , ] dicom_array_3d;
        public double windowWidth = 4000, windowCenter = 1000;

        public Color labelColor = Color.Red;
        bool labeling = false;
        bool labeled = false;
        int labelPositionX, labelPositionY, labelPositionZ;
    }
}

