using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _083005334
{
    public partial class frm_Yonetici : Form
    {
        public frm_Yonetici()
        {
            InitializeComponent();
        }
        public string aktifKullanici;

        BaglantiSinifi Baglan = new BaglantiSinifi();

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_Bilgileri_Guncelle();
            dgv_Guncelle();            
        }

        private void dgv_Guncelle()
        {
            dataGridView1.DataSource = Baglan.TabloGoster("SELECT M_ID,TANIM,ADET,TUR,FIYAT,RESIM FROM MALZEME", CommandType.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Tanim2.Text = dataGridView1.CurrentRow.Cells["TANIM"].Value.ToString();
            textBox_Fiyat2.Text = dataGridView1.CurrentRow.Cells["FIYAT"].Value.ToString();
            textBox_Adet2.Text = dataGridView1.CurrentRow.Cells["ADET"].Value.ToString();
            comboBox_kat2.Text = dataGridView1.CurrentRow.Cells["TUR"].Value.ToString();
            pictureBox_urun.ImageLocation = @"../../resim/"+ dataGridView1.CurrentRow.Cells["RESIM"].Value.ToString();
        }

        private void cb_Bilgileri_Guncelle()
        {
            comboBox_kat1.DataSource = Baglan.TabloGoster("SELECT DISTINCT TUR,TUR_ID FROM MALZEME", CommandType.Text);
            comboBox_kat2.DataSource = Baglan.TabloGoster("SELECT DISTINCT TUR,TUR_ID FROM MALZEME", CommandType.Text);
            comboBox_kat1.ValueMember = comboBox_kat2.ValueMember = "TUR_ID";
            comboBox_kat1.DisplayMember = comboBox_kat2.DisplayMember = "TUR";
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            if (textBox_Tanim1.Text != String.Empty && textBox_Fiyat1.Text != String.Empty && textBox_Adet1.Text != String.Empty)
            {
                object varmi = Baglan.VeriGetir("SELECT TANIM FROM MALZEME WHERE TANIM LIKE '" + textBox_Tanim1.Text + "'", CommandType.Text);
                if (varmi == null)
                {
                    Baglan.VeriGetir("INSERT INTO MALZEME (TANIM,TUR,TUR_ID,FIYAT,ADET,RESIM) VALUES ('" + textBox_Tanim1.Text + "','" + comboBox_kat1.Text + "'," + comboBox_kat1.SelectedValue + "," + textBox_Fiyat1.Text + "," + textBox_Adet1.Text + ",'no.jpg')", CommandType.Text);
                    MessageBox.Show("Yeni Ürün Kaydı Başarıyla Yapıldı!");
                }
                else
                    MessageBox.Show("Ürün Stoklarda Kayıtlıdır, Güncelleme Yapabilirsiniz!");
                dgv_Guncelle();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Baglan.VeriGetir("UPDATE MALZEME SET TANIM='" + textBox_Tanim2.Text + "'" +
                             ",TUR='" + comboBox_kat2.Text + "'" + ",TUR_ID=" + comboBox_kat2.SelectedValue +
                             ",FIYAT=" + textBox_Fiyat2.Text + ",ADET=" + textBox_Adet2.Text +
                             " WHERE M_ID = " + dataGridView1.CurrentRow.Cells["M_ID"].Value.ToString(), CommandType.Text);
            MessageBox.Show("Ürün Bilgileri Başarıyla Güncellendi!");
            dgv_Guncelle();            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Kaydı Silmek İstediğinizden Emin misiniz?", "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Baglan.VeriGetir("DELETE FROM MALZEME WHERE M_ID = " + dataGridView1.CurrentRow.Cells["M_ID"].Value.ToString(), CommandType.Text);
                MessageBox.Show("Ürün Kaydı Başarıyla Silindi!"); dgv_Guncelle();
            }
            else dgv_Guncelle();         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Adet1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_Adet1.Text == "")
            { errorProvider1.SetError(textBox_Adet1, "Lütfen Miktarı Giriniz!"); }
            else errorProvider1.SetError(textBox_Adet1, "");

            try
            {
                int x = int.Parse(textBox_Adet1.Text);
                errorProvider1.SetError(textBox_Adet1, "");
            }
            catch (Exception exp)
            { errorProvider1.SetError(textBox_Adet1, "Lütfen Miktarı Rakam Olarak Giriniz!"); }
        }

        private void textBox_Tanim1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_Tanim1.Text == "")
            { errorProvider1.SetError(textBox_Tanim1, "Lütfen Ürün Adını Giriniz!"); }
            else errorProvider1.SetError(textBox_Tanim1, "");
        }

        private void textBox_Fiyat1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_Fiyat1.Text == "")
            { errorProvider1.SetError(textBox_Fiyat1, "Lütfen Fiyatı Giriniz!"); }
            else errorProvider1.SetError(textBox_Fiyat1, "");

            try
            {
                int x = int.Parse(textBox_Fiyat1.Text);
                errorProvider1.SetError(textBox_Fiyat1, "");
            }
            catch (Exception exp)
            { errorProvider1.SetError(textBox_Fiyat1, "Lütfen Fiyatı Rakam Olarak Giriniz!"); }
        }

        private void yöneticiEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Yonetici admin = new frm_Yonetici();            
            admin.Show();
        }

        private void kullanıcıEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Kullanici user = new frm_Kullanici();
            user.Show();
        }

        private void girişEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
