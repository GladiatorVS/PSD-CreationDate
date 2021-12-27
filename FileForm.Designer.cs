namespace PSD_CreationDate
{
    partial class FileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.slable_file = new System.Windows.Forms.Label();
            this.slable_pv = new System.Windows.Forms.Label();
            this.slable_cd = new System.Windows.Forms.Label();
            this.slable_md = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.pv = new System.Windows.Forms.Label();
            this.cd = new System.Windows.Forms.Label();
            this.md = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.75676F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.24324F));
            this.tableLayoutPanel1.Controls.Add(this.md, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pv, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.slable_file, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.slable_pv, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.slable_cd, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.slable_md, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.fname, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(370, 266);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // slable_file
            // 
            this.slable_file.AutoSize = true;
            this.slable_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slable_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slable_file.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.slable_file.Location = new System.Drawing.Point(3, 0);
            this.slable_file.Name = "slable_file";
            this.slable_file.Size = new System.Drawing.Size(130, 30);
            this.slable_file.TabIndex = 0;
            this.slable_file.Text = "File";
            this.slable_file.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // slable_pv
            // 
            this.slable_pv.AutoSize = true;
            this.slable_pv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slable_pv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slable_pv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.slable_pv.Location = new System.Drawing.Point(3, 30);
            this.slable_pv.Name = "slable_pv";
            this.slable_pv.Size = new System.Drawing.Size(130, 30);
            this.slable_pv.TabIndex = 1;
            this.slable_pv.Text = "Photoshop Version";
            this.slable_pv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // slable_cd
            // 
            this.slable_cd.AutoSize = true;
            this.slable_cd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slable_cd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slable_cd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.slable_cd.Location = new System.Drawing.Point(3, 60);
            this.slable_cd.Name = "slable_cd";
            this.slable_cd.Size = new System.Drawing.Size(130, 30);
            this.slable_cd.TabIndex = 2;
            this.slable_cd.Text = "Creation Date";
            this.slable_cd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // slable_md
            // 
            this.slable_md.AutoSize = true;
            this.slable_md.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slable_md.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slable_md.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.slable_md.Location = new System.Drawing.Point(3, 90);
            this.slable_md.Name = "slable_md";
            this.slable_md.Size = new System.Drawing.Size(130, 30);
            this.slable_md.TabIndex = 3;
            this.slable_md.Text = "Modify Date";
            this.slable_md.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.fname.Location = new System.Drawing.Point(139, 0);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(228, 30);
            this.fname.TabIndex = 4;
            this.fname.Text = "DATA";
            this.fname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pv
            // 
            this.pv.AutoSize = true;
            this.pv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.pv.Location = new System.Drawing.Point(139, 30);
            this.pv.Name = "pv";
            this.pv.Size = new System.Drawing.Size(228, 30);
            this.pv.TabIndex = 5;
            this.pv.Text = "DATA";
            this.pv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cd
            // 
            this.cd.AutoSize = true;
            this.cd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.cd.Location = new System.Drawing.Point(139, 60);
            this.cd.Name = "cd";
            this.cd.Size = new System.Drawing.Size(228, 30);
            this.cd.TabIndex = 6;
            this.cd.Text = "DATA";
            this.cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // md
            // 
            this.md.AutoSize = true;
            this.md.Dock = System.Windows.Forms.DockStyle.Fill;
            this.md.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.md.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.md.Location = new System.Drawing.Point(139, 90);
            this.md.Name = "md";
            this.md.Size = new System.Drawing.Size(228, 30);
            this.md.TabIndex = 7;
            this.md.Text = "DATA";
            this.md.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(370, 266);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Information";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label slable_file;
        private System.Windows.Forms.Label slable_pv;
        private System.Windows.Forms.Label slable_cd;
        private System.Windows.Forms.Label slable_md;
        private System.Windows.Forms.Label md;
        private System.Windows.Forms.Label cd;
        private System.Windows.Forms.Label pv;
        private System.Windows.Forms.Label fname;
    }
}