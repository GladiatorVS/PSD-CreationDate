using MetadataExtractor;
using MetadataExtractor.Formats.Xmp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PSD_CreationDate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            DropBox.AllowDrop = true;
        }

        public struct FileInfo
        {
            public string FileName;
            public string PhotoshopVersion;
            public string CreationDate;
            public string ModifyDate;
            public string Widht;
            public string Height;
        }
        
        private string SearchMeta(string filename, string dir, string tag)
        {
            var Directory = ImageMetadataReader.ReadMetadata(filename);
            foreach (var item in Directory)
            {
                if (item.Name == "Photoshop")
                {
                    foreach (var a_item in item.Tags)
                    {
                        if (a_item.TagName == "Version Info")
                        {
                            return a_item.Description;
                        }
                    }
                }
            }

            return "Unknown";
        }

        private void OpenFileForm(string filename)
        {
            var xmpDirectory            = ImageMetadataReader.ReadMetadata(filename).OfType<XmpDirectory>().FirstOrDefault();

            FileInfo fileInfo           = new FileInfo();
            fileInfo.FileName           = Path.GetFileName(filename);

            string temp_ver = SearchMeta(filename, "Photoshop", "Version Info").Split(',')[1];
            temp_ver = temp_ver.Remove(temp_ver.Length - 3);
            temp_ver = temp_ver.Remove(0,1);

            fileInfo.PhotoshopVersion = temp_ver;

            //fileInfo.PhotoshopVersion = xmpDirectory.XmpMeta.GetProperty("http://ns.adobe.com/xap/1.0/", "xmp:CreatorTool").Value;


            fileInfo.CreationDate       = xmpDirectory.XmpMeta.GetProperty("http://ns.adobe.com/xap/1.0/",  "xmp:CreateDate"        ).Value;
            fileInfo.ModifyDate         = xmpDirectory.XmpMeta.GetProperty("http://ns.adobe.com/xap/1.0/",  "xmp:ModifyDate"        ).Value;
            //fileInfo.Height             = xmpDirectory.XmpMeta.GetProperty("http://ns.adobe.com/exif/1.0/", "exif:PixelYDimension"  ).Value;
            //fileInfo.Widht              = xmpDirectory.XmpMeta.GetProperty("http://ns.adobe.com/exif/1.0/", "exif:PixelXDimension"  ).Value;

            FileForm fileForm = new FileForm(fileInfo);
            fileForm.Show();
        }

        private void DropBox_DragEnter(object sender, DragEventArgs e)
        {
            //string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (Path.GetExtension(((string[])e.Data.GetData(DataFormats.FileDrop))[0]) == ".psd")
            {
                e.Effect = DragDropEffects.Move;
                //DropBox.BackgroundImage = PSD_CreationDate.Properties.Resources.a01;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void DropBox_DragDrop(object sender, DragEventArgs e)
        {
            OpenFileForm(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
        }

        private void DropBox_DragOver(object sender, DragEventArgs e)
        {
            ////string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //if (Path.GetExtension(((string[])e.Data.GetData(DataFormats.FileDrop))[0]) == ".psd")  
            //    DropBox.BackgroundImage = PSD_CreationDate.Properties.Resources.a01;
            //else                                        DropBox.BackgroundImage = PSD_CreationDate.Properties.Resources.a00;
        }

        private void DropBox_DragLeave(object sender, EventArgs e) {
            //DropBox.BackgroundImage = PSD_CreationDate.Properties.Resources.a00;
        }
    }
}
