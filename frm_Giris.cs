using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _083005334
{
    public partial class frm_Giris : Form
    {
        public frm_Giris()
        {
            InitializeComponent();
        }
        // Hocam, Veritabanı bağlantısını bu sınıf ile yapıyorum.
        BaglantiSinifi Baglan = new BaglantiSinifi();

        private void btn_giris_Click(object sender, EventArgs e)
        {
            // Burada Giriş Bilgileri Kontrol Ediliyor.
            KontrolEt();
        }

        public void KontrolEt() 
        {
            string kod = txt_kullaniciAdi.Text.ToLower();
            string sifre = txt_sifre.Text.ToLower();
            object yetki = Baglan.VeriGetir("SELECT YETKI FROM Giris WHERE KOD LIKE '" + kod + "' AND SIFRE LIKE '" + sifre + "'", CommandType.Text);

            if (yetki == null)
            {
                uyari_lbl.BackColor = Color.White; uyari_lbl.ForeColor = Color.Red;
                uyari_lbl.Text = "Lütfen Bilgilerinizi Kontrol Ediniz!";
            }
            else if ((int)yetki == 2)
            {
                frm_Yonetici admin = new frm_Yonetici();
                admin.aktifKullanici = txt_kullaniciAdi.Text;
                admin.Show();
            }
            else if ((int)yetki == 1)
            {
                frm_Kullanici user = new frm_Kullanici();
                user.Show();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_kullaniciAdi_Validating(object sender, CancelEventArgs e)
        {            
            if (txt_kullaniciAdi.Text == "")
            { errorProvider1.SetError(txt_kullaniciAdi, "Lütfen Kodunuzu Giriniz!"); }
            else errorProvider1.SetError(txt_kullaniciAdi, "");
        }

        private void txt_sifre_Validating(object sender, CancelEventArgs e)
        {
            if (txt_sifre.Text == "")
            { errorProvider1.SetError(txt_sifre, "Lütfen Şifrenizi Giriniz!"); }
            else errorProvider1.SetError(txt_sifre, "");
        }

        private void linkLabel1_proje_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("../../083005334.pdf"); 
        }
    }
}
