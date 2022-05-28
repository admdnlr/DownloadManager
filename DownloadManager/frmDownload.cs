using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class frmDownload : Form
    {
        public frmDownload(frmMain frm)
        {
            InitializeComponent();
            _frmMain = frm;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            
            Uri uri = new Uri(this.Url);
            DosyaAdi = System.IO.Path.GetFileName(uri.AbsolutePath);
            client.DownloadFileAsync(uri, Properties.Settings.Default.Path + "/" + DosyaAdi);
            
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description ="Dosya Konumu Seç" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                    Properties.Settings.Default.Path = txtPath.Text;
                    Properties.Settings.Default.Save();
                }
                    
            }
        }

        WebClient client;
        public string Url { get; set; }
        public string DosyaAdi { get; set; }
        public double DosyaBoyutu { get; set; }
        public double Yuzdelik { get; set; }
        private frmMain _frmMain;

        private void frmDownload_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            txtAdres.Text = Url;
            txtPath.Text = Properties.Settings.Default.Path;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Database.FilesRow row = Uygulama.DB.Files.NewFilesRow();
            row.Url = Url;
            row.DosyaAdi = DosyaAdi;
            row.DosyaBoyutu = (string.Format("{0:0.##} KB", DosyaBoyutu / 1024));
            row.Tarih = DateTime.Now;
            Uygulama.DB.Files.AddFilesRow(row);
            Uygulama.DB.AcceptChanges();
            Uygulama.DB.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));
            ListViewItem item = new ListViewItem(row.Id.ToString());
            item.SubItems.Add(row.Url);
            item.SubItems.Add(row.DosyaAdi);
            item.SubItems.Add(row.DosyaBoyutu);
            item.SubItems.Add(row.Tarih.ToLongDateString());
            _frmMain.listView1.Items.Add(item);
            this.Close();
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Minimum = 0;
            double receive = double.Parse(e.ProgressPercentage.ToString());
            DosyaBoyutu = double.Parse(e.TotalBytesToReceive.ToString());
            Yuzdelik = (receive / DosyaBoyutu) * 100;
            lblDurum.Text = $"{string.Format("{0:0.##}",e.ProgressPercentage)} %";
            progressBar.Value = e.ProgressPercentage;
            progressBar.Update();
        }
    }
}
