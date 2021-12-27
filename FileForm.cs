using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSD_CreationDate
{
    public partial class FileForm : Form
    {
        //private MainForm.FileInfo fileInfo = new MainForm.FileInfo();
        public FileForm(MainForm.FileInfo fileInfo)
        {
            InitializeComponent();

            fname.Text = fileInfo.FileName;
            pv.Text = fileInfo.PhotoshopVersion;

            var a = DateTime.Parse(fileInfo.CreationDate);
            cd.Text = a.ToString("yyyy-MM-dd HH:mm:ss");
            a = DateTime.Parse(fileInfo.ModifyDate);
            md.Text = a.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
