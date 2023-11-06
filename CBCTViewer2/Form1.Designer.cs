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
            this.openfolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.savefolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.imageLayoutPanel.SuspendLayout();
            this.serieLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.fileLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 750F));
            this.tableLayoutPanel1.Controls.Add(this.imageLayoutPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.serieLayoutPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fileLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 678);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // imageLayoutPanel
            // 
            this.imageLayoutPanel.Controls.Add(this.zoominButton);
            this.imageLayoutPanel.Controls.Add(this.zoomoutButton);
            this.imageLayoutPanel.Controls.Add(this.colorButton);
            this.imageLayoutPanel.Controls.Add(this.labelButton);
            this.imageLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageLayoutPanel.Location = new System.Drawing.Point(3, 53);
            this.imageLayoutPanel.Name = "imageLayoutPanel";
            this.imageLayoutPanel.Size = new System.Drawing.Size(144, 250);
            this.imageLayoutPanel.TabIndex = 0;
            // 
            // zoominButton
            // 
            this.zoominButton.Location = new System.Drawing.Point(3, 3);
            this.zoominButton.Name = "zoominButton";
            this.zoominButton.Size = new System.Drawing.Size(75, 23);
            this.zoominButton.TabIndex = 0;
            this.zoominButton.Text = "ZoomIn";
            this.zoominButton.UseVisualStyleBackColor = true;
            this.zoominButton.Click += new System.EventHandler(this.zoominButton_Click);
            // 
            // zoomoutButton
            // 
            this.zoomoutButton.Location = new System.Drawing.Point(3, 32);
            this.zoomoutButton.Name = "zoomoutButton";
            this.zoomoutButton.Size = new System.Drawing.Size(75, 23);
            this.zoomoutButton.TabIndex = 1;
            this.zoomoutButton.Text = "ZoomOut";
            this.zoomoutButton.UseVisualStyleBackColor = true;
            this.zoomoutButton.Click += new System.EventHandler(this.zoomoutButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(3, 61);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 2;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // labelButton
            // 
            this.labelButton.Location = new System.Drawing.Point(3, 90);
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(75, 23);
            this.labelButton.TabIndex = 3;
            this.labelButton.Text = "LABEL";
            this.labelButton.UseVisualStyleBackColor = true;
            this.labelButton.Click += new System.EventHandler(this.labelButton_Click);
            // 
            // serieLayoutPanel
            // 
            this.serieLayoutPanel.Controls.Add(this.lastButton);
            this.serieLayoutPanel.Controls.Add(this.trackBar);
            this.serieLayoutPanel.Controls.Add(this.nextButton);
            this.serieLayoutPanel.Controls.Add(this.numbertextBox);
            this.serieLayoutPanel.Controls.Add(this.numLabel);
            this.serieLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serieLayoutPanel.Location = new System.Drawing.Point(3, 309);
            this.serieLayoutPanel.Name = "serieLayoutPanel";
            this.serieLayoutPanel.Size = new System.Drawing.Size(144, 366);
            this.serieLayoutPanel.TabIndex = 0;
            this.serieLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.serieLayoutPanel_Paint);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(3, 3);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(75, 23);
            this.lastButton.TabIndex = 0;
            this.lastButton.Text = "Last";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(3, 32);
            this.trackBar.Maximum = 0;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(104, 56);
            this.trackBar.TabIndex = 3;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(3, 94);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // numbertextBox
            // 
            this.numbertextBox.Location = new System.Drawing.Point(3, 123);
            this.numbertextBox.Name = "numbertextBox";
            this.numbertextBox.Size = new System.Drawing.Size(75, 25);
            this.numbertextBox.TabIndex = 2;
            this.numbertextBox.TextChanged += new System.EventHandler(this.numbertextBox_TextChanged);
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(3, 151);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(95, 15);
            this.numLabel.TabIndex = 4;
            this.numLabel.Text = "of 0 slices";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(153, 53);
            this.pictureBox.Name = "pictureBox";
            // this.pictureBox.Image = global::CBCTLabeler.Properties.Resources.background;
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox, 2);
            this.pictureBox.Size = new System.Drawing.Size(744, 622);
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
            this.fileLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.fileLayoutPanel.Name = "fileLayoutPanel";
            this.fileLayoutPanel.Size = new System.Drawing.Size(894, 44);
            this.fileLayoutPanel.TabIndex = 2;
            // 
            // OpenFile
            // 
            this.OpenFile.AutoSize = true;
            this.OpenFile.Location = new System.Drawing.Point(3, 3);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(81, 25);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "OpenFile";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // CloseFile
            // 
            this.CloseFile.AutoSize = true;
            this.CloseFile.Location = new System.Drawing.Point(90, 3);
            this.CloseFile.Name = "CloseFile";
            this.CloseFile.Size = new System.Drawing.Size(89, 25);
            this.CloseFile.TabIndex = 1;
            this.CloseFile.Text = "CloseFile";
            this.CloseFile.UseVisualStyleBackColor = true;
            this.CloseFile.Click += new System.EventHandler(this.CloseFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.AutoSize = true;
            this.SaveFile.Location = new System.Drawing.Point(185, 3);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(81, 25);
            this.SaveFile.TabIndex = 2;
            this.SaveFile.Text = "SaveFile";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 678);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "CBCTLabeler";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.imageLayoutPanel.ResumeLayout(false);
            this.serieLayoutPanel.ResumeLayout(false);
            this.serieLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.fileLayoutPanel.ResumeLayout(false);
            this.fileLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel serieLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.FlowLayoutPanel fileLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel imageLayoutPanel;
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
        private System.Windows.Forms.FolderBrowserDialog savefolderDialog;
        private System.Windows.Forms.TextBox numbertextBox;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label numLabel;

        public int num = 0;
        public int imageNumber = 0;
        public int [ , , ] dicom_array_3d;
        public int window_width = 4000, window_center = 1000;
        private System.Windows.Forms.ColorDialog colorDialog;

        public Color labelColor = Color.Red;
        bool labeling = false;
        bool labeled = false;
    }
}

