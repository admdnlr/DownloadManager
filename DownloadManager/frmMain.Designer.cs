namespace DownloadManager
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsUrlEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsKaldır = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAyarlar = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUrlEkle,
            this.toolStripSeparator1,
            this.tsKaldır,
            this.toolStripSeparator2,
            this.tsAyarlar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(729, 80);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsUrlEkle
            // 
            this.tsUrlEkle.AutoSize = false;
            this.tsUrlEkle.Image = global::DownloadManager.Properties.Resources._5402394_internet_link_hyperlink_url_web_icon;
            this.tsUrlEkle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUrlEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUrlEkle.Name = "tsUrlEkle";
            this.tsUrlEkle.Size = new System.Drawing.Size(75, 75);
            this.tsUrlEkle.Text = "Url Ekle";
            this.tsUrlEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUrlEkle.Click += new System.EventHandler(this.tsUrlEkle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 80);
            // 
            // tsKaldır
            // 
            this.tsKaldır.AutoSize = false;
            this.tsKaldır.Image = global::DownloadManager.Properties.Resources._370086_bin_delete_empty_out_recycle_icon;
            this.tsKaldır.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsKaldır.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKaldır.Name = "tsKaldır";
            this.tsKaldır.Size = new System.Drawing.Size(75, 75);
            this.tsKaldır.Text = "Kaldır";
            this.tsKaldır.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsKaldır.Click += new System.EventHandler(this.tsKaldır_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 80);
            // 
            // tsAyarlar
            // 
            this.tsAyarlar.AutoSize = false;
            this.tsAyarlar.Image = global::DownloadManager.Properties.Resources._3844474_gear_setting_settings_wheel_icon;
            this.tsAyarlar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAyarlar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAyarlar.Name = "tsAyarlar";
            this.tsAyarlar.Size = new System.Drawing.Size(75, 75);
            this.tsAyarlar.Text = "Ayarlar";
            this.tsAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAyarlar.Click += new System.EventHandler(this.tsAyarlar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(729, 218);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Url";
            this.columnHeader2.Width = 275;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Dosya Adi";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dosya Boyutu";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tarih";
            this.columnHeader5.Width = 150;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 298);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "DownloadManager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsUrlEkle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsKaldır;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsAyarlar;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

