using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsAyarlar_Click(object sender, EventArgs e)
        {
            using(frmAyarlar frm = new frmAyarlar())
            {
                frm.ShowDialog();
            }
        }

        private void tsUrlEkle_Click(object sender, EventArgs e)
        {
            using(frmEkle frm = new frmEkle())
            {
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    frmDownload frmDownload = new frmDownload(this);
                    frmDownload.Url = frm.Url;
                    frmDownload.Show();
                }
            }
        }

        private void tsKaldır_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?","Mesaj",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = listView1.SelectedItems.Count; i >0; i--)
                {
                    ListViewItem item = listView1.SelectedItems[i - 1];
                    Uygulama.DB.Files.Rows[item.Index].Delete();
                    listView1.Items[item.Index].Remove();
                }
                Uygulama.DB.AcceptChanges();
                Uygulama.DB.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string dosyaAdi = String.Format("{0}/data.dat", Application.StartupPath);
            if (File.Exists(dosyaAdi))
                Uygulama.DB.ReadXml(dosyaAdi);
            foreach (Database.FilesRow row in Uygulama.DB.Files)
            {
                ListViewItem item = new ListViewItem(row.Id.ToString());
                item.SubItems.Add(row.Url);
                item.SubItems.Add(row.DosyaAdi);
                item.SubItems.Add(row.DosyaBoyutu);
                item.SubItems.Add(row.Tarih.ToLongDateString());
                listView1.Items.Add(item);
            }
        }
    }
}
