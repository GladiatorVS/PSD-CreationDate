namespace PSD_CreationDate
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DropBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DropBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DropBox
            // 
            this.DropBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.DropBox.BackgroundImage = global::PSD_CreationDate.Properties.Resources.a00;
            this.DropBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DropBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DropBox.Location = new System.Drawing.Point(0, 0);
            this.DropBox.Margin = new System.Windows.Forms.Padding(0);
            this.DropBox.Name = "DropBox";
            this.DropBox.Size = new System.Drawing.Size(484, 461);
            this.DropBox.TabIndex = 1;
            this.DropBox.TabStop = false;
            this.DropBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropBox_DragDrop);
            this.DropBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropBox_DragEnter);
            this.DropBox.DragOver += new System.Windows.Forms.DragEventHandler(this.DropBox_DragOver);
            this.DropBox.DragLeave += new System.EventHandler(this.DropBox_DragLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.DropBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSD CreationDate";
            ((System.ComponentModel.ISupportInitialize)(this.DropBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox DropBox;
    }
}

