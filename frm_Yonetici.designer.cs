namespace _083005334
{
    partial class frm_Yonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Yonetici));
            this.groupBox_yeni = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Adet1 = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Fiyat1 = new System.Windows.Forms.TextBox();
            this.textBox_Tanim1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_kat1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.groupBox_guncel = new System.Windows.Forms.GroupBox();
            this.pictureBox_urun = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Adet2 = new System.Windows.Forms.TextBox();
            this.textBox_Fiyat2 = new System.Windows.Forms.TextBox();
            this.textBox_Tanim2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_kat2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yöneticiEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_yeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox_guncel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_urun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_yeni
            // 
            this.groupBox_yeni.Controls.Add(this.label6);
            this.groupBox_yeni.Controls.Add(this.label8);
            this.groupBox_yeni.Controls.Add(this.textBox_Adet1);
            this.groupBox_yeni.Controls.Add(this.buttonEkle);
            this.groupBox_yeni.Controls.Add(this.label5);
            this.groupBox_yeni.Controls.Add(this.label4);
            this.groupBox_yeni.Controls.Add(this.label3);
            this.groupBox_yeni.Controls.Add(this.textBox_Fiyat1);
            this.groupBox_yeni.Controls.Add(this.textBox_Tanim1);
            this.groupBox_yeni.Controls.Add(this.label2);
            this.groupBox_yeni.Controls.Add(this.comboBox_kat1);
            this.groupBox_yeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_yeni.Location = new System.Drawing.Point(21, 273);
            this.groupBox_yeni.Name = "groupBox_yeni";
            this.groupBox_yeni.Size = new System.Drawing.Size(283, 185);
            this.groupBox_yeni.TabIndex = 1;
            this.groupBox_yeni.TabStop = false;
            this.groupBox_yeni.Text = "Yeni Ürün Ekle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(8, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Stok Miktarı";
            // 
            // textBox_Adet1
            // 
            this.textBox_Adet1.Location = new System.Drawing.Point(96, 102);
            this.textBox_Adet1.Name = "textBox_Adet1";
            this.textBox_Adet1.Size = new System.Drawing.Size(132, 22);
            this.textBox_Adet1.TabIndex = 3;
            this.textBox_Adet1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Adet1_Validating);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEkle.Image = ((System.Drawing.Image)(resources.GetObject("buttonEkle.Image")));
            this.buttonEkle.Location = new System.Drawing.Point(96, 135);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(132, 43);
            this.buttonEkle.TabIndex = 4;
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(8, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(8, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün Adı";
            // 
            // textBox_Fiyat1
            // 
            this.textBox_Fiyat1.Location = new System.Drawing.Point(96, 76);
            this.textBox_Fiyat1.Name = "textBox_Fiyat1";
            this.textBox_Fiyat1.Size = new System.Drawing.Size(132, 22);
            this.textBox_Fiyat1.TabIndex = 2;
            this.textBox_Fiyat1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Fiyat1_Validating);
            // 
            // textBox_Tanim1
            // 
            this.textBox_Tanim1.Location = new System.Drawing.Point(96, 50);
            this.textBox_Tanim1.Name = "textBox_Tanim1";
            this.textBox_Tanim1.Size = new System.Drawing.Size(132, 22);
            this.textBox_Tanim1.TabIndex = 1;
            this.textBox_Tanim1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Tanim1_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // comboBox_kat1
            // 
            this.comboBox_kat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kat1.FormattingEnabled = true;
            this.comboBox_kat1.Location = new System.Drawing.Point(96, 23);
            this.comboBox_kat1.Name = "comboBox_kat1";
            this.comboBox_kat1.Size = new System.Drawing.Size(132, 24);
            this.comboBox_kat1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(606, 216);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(21, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 241);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stok / Depo Listesi";
            // 
            // buttonSil
            // 
            this.buttonSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSil.Image = ((System.Drawing.Image)(resources.GetObject("buttonSil.Image")));
            this.buttonSil.Location = new System.Drawing.Point(225, 136);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(109, 42);
            this.buttonSil.TabIndex = 10;
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuncelle.Image")));
            this.buttonGuncelle.Location = new System.Drawing.Point(97, 136);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(122, 42);
            this.buttonGuncelle.TabIndex = 9;
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox_guncel
            // 
            this.groupBox_guncel.Controls.Add(this.pictureBox_urun);
            this.groupBox_guncel.Controls.Add(this.buttonSil);
            this.groupBox_guncel.Controls.Add(this.buttonGuncelle);
            this.groupBox_guncel.Controls.Add(this.label1);
            this.groupBox_guncel.Controls.Add(this.textBox_Adet2);
            this.groupBox_guncel.Controls.Add(this.textBox_Fiyat2);
            this.groupBox_guncel.Controls.Add(this.textBox_Tanim2);
            this.groupBox_guncel.Controls.Add(this.label9);
            this.groupBox_guncel.Controls.Add(this.label10);
            this.groupBox_guncel.Controls.Add(this.label11);
            this.groupBox_guncel.Controls.Add(this.label7);
            this.groupBox_guncel.Controls.Add(this.label12);
            this.groupBox_guncel.Controls.Add(this.comboBox_kat2);
            this.groupBox_guncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_guncel.Location = new System.Drawing.Point(310, 273);
            this.groupBox_guncel.Name = "groupBox_guncel";
            this.groupBox_guncel.Size = new System.Drawing.Size(338, 185);
            this.groupBox_guncel.TabIndex = 1;
            this.groupBox_guncel.TabStop = false;
            this.groupBox_guncel.Text = "Seçili Ürünü Güncelle";
            // 
            // pictureBox_urun
            // 
            this.pictureBox_urun.Location = new System.Drawing.Point(239, 35);
            this.pictureBox_urun.Name = "pictureBox_urun";
            this.pictureBox_urun.Size = new System.Drawing.Size(83, 92);
            this.pictureBox_urun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_urun.TabIndex = 14;
            this.pictureBox_urun.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Stok Miktarı";
            // 
            // textBox_Adet2
            // 
            this.textBox_Adet2.Location = new System.Drawing.Point(92, 108);
            this.textBox_Adet2.Name = "textBox_Adet2";
            this.textBox_Adet2.Size = new System.Drawing.Size(132, 22);
            this.textBox_Adet2.TabIndex = 8;
            // 
            // textBox_Fiyat2
            // 
            this.textBox_Fiyat2.Location = new System.Drawing.Point(92, 82);
            this.textBox_Fiyat2.Name = "textBox_Fiyat2";
            this.textBox_Fiyat2.Size = new System.Drawing.Size(132, 22);
            this.textBox_Fiyat2.TabIndex = 7;
            // 
            // textBox_Tanim2
            // 
            this.textBox_Tanim2.Location = new System.Drawing.Point(92, 56);
            this.textBox_Tanim2.Name = "textBox_Tanim2";
            this.textBox_Tanim2.Size = new System.Drawing.Size(132, 22);
            this.textBox_Tanim2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(6, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ürün Fiyatı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(6, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ürün Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(248, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fotoğrafı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(6, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Kategori";
            // 
            // comboBox_kat2
            // 
            this.comboBox_kat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kat2.FormattingEnabled = true;
            this.comboBox_kat2.Location = new System.Drawing.Point(92, 29);
            this.comboBox_kat2.Name = "comboBox_kat2";
            this.comboBox_kat2.Size = new System.Drawing.Size(132, 24);
            this.comboBox_kat2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(648, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiEkranıToolStripMenuItem,
            this.kullanıcıEkranıToolStripMenuItem,
            this.girişEkranıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(21, -1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(310, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "Ana Menu";
            // 
            // yöneticiEkranıToolStripMenuItem
            // 
            this.yöneticiEkranıToolStripMenuItem.Name = "yöneticiEkranıToolStripMenuItem";
            this.yöneticiEkranıToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.yöneticiEkranıToolStripMenuItem.Text = "Yönetici Ekranı";
            this.yöneticiEkranıToolStripMenuItem.Click += new System.EventHandler(this.yöneticiEkranıToolStripMenuItem_Click);
            // 
            // kullanıcıEkranıToolStripMenuItem
            // 
            this.kullanıcıEkranıToolStripMenuItem.Name = "kullanıcıEkranıToolStripMenuItem";
            this.kullanıcıEkranıToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.kullanıcıEkranıToolStripMenuItem.Text = "Kullanıcı Ekranı";
            this.kullanıcıEkranıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEkranıToolStripMenuItem_Click);
            // 
            // girişEkranıToolStripMenuItem
            // 
            this.girişEkranıToolStripMenuItem.Name = "girişEkranıToolStripMenuItem";
            this.girişEkranıToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.girişEkranıToolStripMenuItem.Text = "Giriş Ekranı";
            this.girişEkranıToolStripMenuItem.Click += new System.EventHandler(this.girişEkranıToolStripMenuItem_Click);
            // 
            // frm_Yonetici
            // 
            this.AcceptButton = this.buttonEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(676, 472);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_guncel);
            this.Controls.Add(this.groupBox_yeni);
            this.Name = "frm_Yonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_yeni.ResumeLayout(false);
            this.groupBox_yeni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox_guncel.ResumeLayout(false);
            this.groupBox_guncel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_urun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_yeni;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Fiyat1;
        private System.Windows.Forms.TextBox textBox_Tanim1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_kat1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Adet1;
        private System.Windows.Forms.GroupBox groupBox_guncel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox_urun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yöneticiEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişEkranıToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_Adet2;
        private System.Windows.Forms.TextBox textBox_Fiyat2;
        private System.Windows.Forms.TextBox textBox_Tanim2;
        private System.Windows.Forms.ComboBox comboBox_kat2;
    }
}

