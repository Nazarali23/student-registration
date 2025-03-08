namespace liste_ekle_çıkar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kontrol_ekleme = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numara_kontrol = new System.Windows.Forms.TextBox();
            this.b_n_l = new System.Windows.Forms.Label();
            this.ana_ekrana_don = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.liste = new System.Windows.Forms.Button();
            this.ogrenci_listesi = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOYAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMARA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BÖLÜM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.göster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bilgiler2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.kaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numaratxt = new System.Windows.Forms.TextBox();
            this.adrestxt = new System.Windows.Forms.TextBox();
            this.bolumtxt = new System.Windows.Forms.TextBox();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.b_ab_l = new System.Windows.Forms.Label();
            this.b_b_l = new System.Windows.Forms.Label();
            this.b_s_l = new System.Windows.Forms.Label();
            this.b_a_l = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ogrenci_listesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bilgiler2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // sil
            // 
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.Location = new System.Drawing.Point(439, 331);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(200, 60);
            this.sil.TabIndex = 2;
            this.sil.Text = "KAYIT SİLME";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.kontrol_ekleme);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.sil);
            this.panel2.Controls.Add(this.numara_kontrol);
            this.panel2.Controls.Add(this.b_n_l);
            this.panel2.Location = new System.Drawing.Point(22, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 700);
            this.panel2.TabIndex = 10;
            // 
            // kontrol_ekleme
            // 
            this.kontrol_ekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kontrol_ekleme.Location = new System.Drawing.Point(439, 230);
            this.kontrol_ekleme.Name = "kontrol_ekleme";
            this.kontrol_ekleme.Size = new System.Drawing.Size(200, 60);
            this.kontrol_ekleme.TabIndex = 21;
            this.kontrol_ekleme.Text = "YENİ KAYIT EKLEME";
            this.kontrol_ekleme.UseVisualStyleBackColor = true;
            this.kontrol_ekleme.Click += new System.EventHandler(this.kontrol_ekleme_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(175, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 96);
            this.label4.TabIndex = 12;
            this.label4.Text = "\r\n     Öğrenci bilgi sistemi    \r\n \r\n";
            // 
            // numara_kontrol
            // 
            this.numara_kontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numara_kontrol.Location = new System.Drawing.Point(78, 347);
            this.numara_kontrol.MaxLength = 9;
            this.numara_kontrol.Name = "numara_kontrol";
            this.numara_kontrol.Size = new System.Drawing.Size(220, 28);
            this.numara_kontrol.TabIndex = 9;
            // 
            // b_n_l
            // 
            this.b_n_l.AutoSize = true;
            this.b_n_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_n_l.Location = new System.Drawing.Point(48, 258);
            this.b_n_l.Name = "b_n_l";
            this.b_n_l.Size = new System.Drawing.Size(298, 32);
            this.b_n_l.TabIndex = 20;
            this.b_n_l.Text = "ÖĞRENCİ NUMARASI";
            // 
            // ana_ekrana_don
            // 
            this.ana_ekrana_don.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ana_ekrana_don.Location = new System.Drawing.Point(113, 24);
            this.ana_ekrana_don.Name = "ana_ekrana_don";
            this.ana_ekrana_don.Size = new System.Drawing.Size(199, 62);
            this.ana_ekrana_don.TabIndex = 16;
            this.ana_ekrana_don.Text = "ANA EKRAN";
            this.ana_ekrana_don.UseVisualStyleBackColor = true;
            this.ana_ekrana_don.Click += new System.EventHandler(this.ana_ekrana_don_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.liste);
            this.panel1.Controls.Add(this.ana_ekrana_don);
            this.panel1.Location = new System.Drawing.Point(0, 750);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 100);
            this.panel1.TabIndex = 17;
            // 
            // liste
            // 
            this.liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.liste.Location = new System.Drawing.Point(391, 26);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(199, 62);
            this.liste.TabIndex = 17;
            this.liste.Text = "ÖĞRENCİ LİSTESİ\r\n";
            this.liste.UseVisualStyleBackColor = true;
            this.liste.Click += new System.EventHandler(this.liste_Click);
            // 
            // ogrenci_listesi
            // 
            this.ogrenci_listesi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ogrenci_listesi.Controls.Add(this.dataGridView1);
            this.ogrenci_listesi.Controls.Add(this.göster);
            this.ogrenci_listesi.Controls.Add(this.label1);
            this.ogrenci_listesi.Location = new System.Drawing.Point(21, 28);
            this.ogrenci_listesi.Name = "ogrenci_listesi";
            this.ogrenci_listesi.Size = new System.Drawing.Size(686, 700);
            this.ogrenci_listesi.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AD,
            this.SOYAD,
            this.NUMARA,
            this.BÖLÜM,
            this.ADRES});
            this.dataGridView1.Location = new System.Drawing.Point(30, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 466);
            this.dataGridView1.TabIndex = 23;
            // 
            // AD
            // 
            this.AD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AD.HeaderText = "AD         ";
            this.AD.MinimumWidth = 6;
            this.AD.Name = "AD";
            this.AD.Width = 82;
            // 
            // SOYAD
            // 
            this.SOYAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SOYAD.HeaderText = "SOYAD    ";
            this.SOYAD.MinimumWidth = 6;
            this.SOYAD.Name = "SOYAD";
            this.SOYAD.Width = 95;
            // 
            // NUMARA
            // 
            this.NUMARA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NUMARA.HeaderText = "NUMARA    ";
            this.NUMARA.MinimumWidth = 6;
            this.NUMARA.Name = "NUMARA";
            this.NUMARA.Width = 107;
            // 
            // BÖLÜM
            // 
            this.BÖLÜM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BÖLÜM.HeaderText = "BOLUM    ";
            this.BÖLÜM.MinimumWidth = 6;
            this.BÖLÜM.Name = "BÖLÜM";
            this.BÖLÜM.Width = 95;
            // 
            // ADRES
            // 
            this.ADRES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ADRES.HeaderText = "ADRES      ";
            this.ADRES.MinimumWidth = 6;
            this.ADRES.Name = "ADRES";
            this.ADRES.Width = 101;
            // 
            // göster
            // 
            this.göster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.göster.Location = new System.Drawing.Point(230, 582);
            this.göster.Name = "göster";
            this.göster.Size = new System.Drawing.Size(233, 62);
            this.göster.TabIndex = 21;
            this.göster.Text = "GÜNCELLE\r\n";
            this.göster.UseVisualStyleBackColor = true;
            this.göster.Click += new System.EventHandler(this.göster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(194, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kayıtlı Öğrenci Listesi:\r\n";
            // 
            // bilgiler2
            // 
            this.bilgiler2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bilgiler2.Controls.Add(this.panel4);
            this.bilgiler2.Controls.Add(this.label2);
            this.bilgiler2.Controls.Add(this.panel5);
            this.bilgiler2.Location = new System.Drawing.Point(22, 28);
            this.bilgiler2.Name = "bilgiler2";
            this.bilgiler2.Size = new System.Drawing.Size(688, 700);
            this.bilgiler2.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Cursor = System.Windows.Forms.Cursors.No;
            this.panel4.Location = new System.Drawing.Point(457, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 119);
            this.panel4.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(122, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "BİLGİLER:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightBlue;
            this.panel5.Controls.Add(this.kaydet);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.numaratxt);
            this.panel5.Controls.Add(this.adrestxt);
            this.panel5.Controls.Add(this.bolumtxt);
            this.panel5.Controls.Add(this.soyadtxt);
            this.panel5.Controls.Add(this.adtxt);
            this.panel5.Controls.Add(this.b_ab_l);
            this.panel5.Controls.Add(this.b_b_l);
            this.panel5.Controls.Add(this.b_s_l);
            this.panel5.Controls.Add(this.b_a_l);
            this.panel5.Location = new System.Drawing.Point(43, 163);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(605, 502);
            this.panel5.TabIndex = 19;
            // 
            // kaydet
            // 
            this.kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet.Location = new System.Drawing.Point(187, 420);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(233, 62);
            this.kaydet.TabIndex = 27;
            this.kaydet.Text = "KAYDET";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(78, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "NUMARA";
            // 
            // numaratxt
            // 
            this.numaratxt.Enabled = false;
            this.numaratxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numaratxt.Location = new System.Drawing.Point(274, 145);
            this.numaratxt.Name = "numaratxt";
            this.numaratxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.numaratxt.Size = new System.Drawing.Size(262, 28);
            this.numaratxt.TabIndex = 24;
            // 
            // adrestxt
            // 
            this.adrestxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adrestxt.Location = new System.Drawing.Point(86, 314);
            this.adrestxt.Multiline = true;
            this.adrestxt.Name = "adrestxt";
            this.adrestxt.Size = new System.Drawing.Size(452, 90);
            this.adrestxt.TabIndex = 26;
            // 
            // bolumtxt
            // 
            this.bolumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolumtxt.Location = new System.Drawing.Point(274, 201);
            this.bolumtxt.Name = "bolumtxt";
            this.bolumtxt.Size = new System.Drawing.Size(262, 28);
            this.bolumtxt.TabIndex = 25;
            // 
            // soyadtxt
            // 
            this.soyadtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadtxt.Location = new System.Drawing.Point(274, 85);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(262, 28);
            this.soyadtxt.TabIndex = 23;
            // 
            // adtxt
            // 
            this.adtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adtxt.Location = new System.Drawing.Point(274, 31);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(262, 28);
            this.adtxt.TabIndex = 22;
            // 
            // b_ab_l
            // 
            this.b_ab_l.AutoSize = true;
            this.b_ab_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_ab_l.Location = new System.Drawing.Point(181, 263);
            this.b_ab_l.Name = "b_ab_l";
            this.b_ab_l.Size = new System.Drawing.Size(251, 32);
            this.b_ab_l.TabIndex = 21;
            this.b_ab_l.Text = "ADRES BİLGİLERİ";
            // 
            // b_b_l
            // 
            this.b_b_l.AutoSize = true;
            this.b_b_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_b_l.Location = new System.Drawing.Point(78, 201);
            this.b_b_l.Name = "b_b_l";
            this.b_b_l.Size = new System.Drawing.Size(114, 32);
            this.b_b_l.TabIndex = 20;
            this.b_b_l.Text = "BÖLÜM";
            // 
            // b_s_l
            // 
            this.b_s_l.AutoSize = true;
            this.b_s_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_s_l.Location = new System.Drawing.Point(80, 85);
            this.b_s_l.Name = "b_s_l";
            this.b_s_l.Size = new System.Drawing.Size(95, 32);
            this.b_s_l.TabIndex = 18;
            this.b_s_l.Text = "Soyad";
            // 
            // b_a_l
            // 
            this.b_a_l.AutoSize = true;
            this.b_a_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_a_l.Location = new System.Drawing.Point(80, 31);
            this.b_a_l.Name = "b_a_l";
            this.b_a_l.Size = new System.Drawing.Size(49, 32);
            this.b_a_l.TabIndex = 17;
            this.b_a_l.Text = "Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 668);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "NAZARALI UMURKULOV\r\n         233908662";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(733, 850);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bilgiler2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ogrenci_listesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ogrenci_listesi.ResumeLayout(false);
            this.ogrenci_listesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bilgiler2.ResumeLayout(false);
            this.bilgiler2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label b_n_l;
        private System.Windows.Forms.Button kontrol_ekleme;
        private System.Windows.Forms.Button ana_ekrana_don;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button liste;
        public System.Windows.Forms.TextBox numara_kontrol;
        private System.Windows.Forms.Panel ogrenci_listesi;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button göster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel bilgiler2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox numaratxt;
        public System.Windows.Forms.TextBox adrestxt;
        public System.Windows.Forms.TextBox bolumtxt;
        public System.Windows.Forms.TextBox soyadtxt;
        public System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.Label b_ab_l;
        private System.Windows.Forms.Label b_b_l;
        private System.Windows.Forms.Label b_s_l;
        private System.Windows.Forms.Label b_a_l;
        private System.Windows.Forms.DataGridViewTextBoxColumn AD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOYAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMARA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BÖLÜM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRES;
        private System.Windows.Forms.Label label5;
    }
}

