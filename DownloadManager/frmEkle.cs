using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class frmEkle : Form
    {
        public frmEkle()
        {
            InitializeComponent();
        }

        public string Url { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Url = txtUrl.Text;
        }
    }
}
