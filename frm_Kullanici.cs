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
    public partial class frm_Kullanici : Form
    {
        public frm_Kullanici()
        {
            InitializeComponent();
        }
        BaglantiSinifi Baglan = new BaglantiSinifi();

        private void frm_kasiyerEkrani_Load(object sender, EventArgs e)
        {
            dgv_Guncelle();
        }

        private void dgv_Guncelle()
        {
            dataGridView1.DataSource = Baglan.TabloGoster("SELECT M_ID,TANIM,ADET,TUR,FIYAT,RESIM FROM MALZEME", CommandType.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            label_id.Text = dataGridView1.CurrentRow.Cells["M_ID"].Value.ToString();
            label_urun.Text = dataGridView1.CurrentRow.Cells["TANIM"].Value.ToString();
            pictureBox_urun.ImageLocation = @"../../resim/" + dataGridView1.CurrentRow.Cells["RESIM"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_miktar.Text != String.Empty)
            {
                DialogResult d = MessageBox.Show("Seçilen Ürün Miktarını Stoktan Düşürmek İstediğinizden Emin misiniz?", "Onay Ekranı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    object mid = dataGridView1.CurrentRow.Cells["M_ID"].Value;
                    object stok = Baglan.VeriGetir("SELECT ADET FROM MALZEME WHERE M_ID=" + mid.ToString(), CommandType.Text);
                    if ((int)stok >= Convert.ToInt32(textBox_miktar.Text))
                    {
                        int aktifStok = (int)stok;
                        aktifStok -= Convert.ToInt32(textBox_miktar.Text);
                        Baglan.VeriGetir("UPDATE MALZEME SET ADET=" + aktifStok.ToString() + " WHERE M_ID=" + mid.ToString(), CommandType.Text);
                        MessageBox.Show(textBox_miktar.Text + " Adet Ürün Stoktan Düşülmüştür!");
                        dgv_Guncelle();
                    }
                    else MessageBox.Show("Stokta Belirtilen Miktardan Malzeme Yoktur!");
                }
                else dgv_Guncelle();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_miktar_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_miktar.Text == "")
            { errorProvider1.SetError(textBox_miktar, "Lütfen Miktarı Giriniz!"); }
            else errorProvider1.SetError(textBox_miktar, "");

            try
            {
                int x = int.Parse(textBox_miktar.Text);
                errorProvider1.SetError(textBox_miktar, "");
            }
            catch (Exception exp)
            { errorProvider1.SetError(textBox_miktar, "Lütfen Miktarı Rakam Olarak Giriniz!"); }
        }

        private void yöneticiEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
