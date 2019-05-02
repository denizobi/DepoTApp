namespace _083005334
{
    partial class frm_Giris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Giris));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_kAdi = new System.Windows.Forms.Label();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.uyari_lbl = new System.Windows.Forms.Label();
            this.pb_girisResim = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1_proje = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_girisResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_kAdi
            // 
            this.lbl_kAdi.AutoSize = true;
            this.lbl_kAdi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_kAdi.Location = new System.Drawing.Point(141, 41);
            this.lbl_kAdi.Name = "lbl_kAdi";
            this.lbl_kAdi.Size = new System.Drawing.Size(101, 16);
            this.lbl_kAdi.TabIndex = 2;
            this.lbl_kAdi.Text = "Kullanıcı Kodu";
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(261, 39);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(113, 22);
            this.txt_kullaniciAdi.TabIndex = 0;
            this.txt_kullaniciAdi.Validating += new System.ComponentModel.CancelEventHandler(this.txt_kullaniciAdi_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(141, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Parola";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(261, 67);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(113, 22);
            this.txt_sifre.TabIndex = 1;
            this.txt_sifre.Validating += new System.ComponentModel.CancelEventHandler(this.txt_sifre_Validating);
            // 
            // btn_giris
            // 
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.Image = ((System.Drawing.Image)(resources.GetObject("btn_giris.Image")));
            this.btn_giris.Location = new System.Drawing.Point(261, 94);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(114, 38);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // uyari_lbl
            // 
            this.uyari_lbl.AutoSize = true;
            this.uyari_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyari_lbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.uyari_lbl.Location = new System.Drawing.Point(141, 19);
            this.uyari_lbl.Name = "uyari_lbl";
            this.uyari_lbl.Size = new System.Drawing.Size(179, 16);
            this.uyari_lbl.TabIndex = 6;
            this.uyari_lbl.Text = "Lütfen Bilgilerinizi Giriniz..";
            // 
            // pb_girisResim
            // 
            this.pb_girisResim.Image = ((System.Drawing.Image)(resources.GetObject("pb_girisResim.Image")));
            this.pb_girisResim.Location = new System.Drawing.Point(6, 18);
            this.pb_girisResim.Name = "pb_girisResim";
            this.pb_girisResim.Size = new System.Drawing.Size(129, 80);
            this.pb_girisResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_girisResim.TabIndex = 5;
            this.pb_girisResim.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(371, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.linkLabel1_proje);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pb_girisResim);
            this.groupBox1.Controls.Add(this.uyari_lbl);
            this.groupBox1.Controls.Add(this.btn_giris);
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_kullaniciAdi);
            this.groupBox1.Controls.Add(this.lbl_kAdi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(0, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 135);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // linkLabel1_proje
            // 
            this.linkLabel1_proje.AutoSize = true;
            this.linkLabel1_proje.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1_proje.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabel1_proje.Location = new System.Drawing.Point(13, 104);
            this.linkLabel1_proje.Name = "linkLabel1_proje";
            this.linkLabel1_proje.Size = new System.Drawing.Size(120, 16);
            this.linkLabel1_proje.TabIndex = 8;
            this.linkLabel1_proje.TabStop = true;
            this.linkLabel1_proje.Text = "{ Proje Raporu }";
            this.linkLabel1_proje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1_proje.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_proje_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // frm_Giris
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(396, 187);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_girisResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_girisResim;
        private System.Windows.Forms.Label uyari_lbl;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label lbl_kAdi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1_proje;
    }
}