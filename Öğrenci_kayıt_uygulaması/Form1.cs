using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace liste_ekle_çıkar
{
    public partial class Form1 : Form
    {
        Liste l = new Liste();
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(Application.ExecutablePath.ToString());  

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Show();
            panel2.BringToFront();
            ogrenci_listesi.Hide();
            bilgiler2.Hide();       
        }
        private void sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numara_kontrol.Text))
            {
                MessageBox.Show("Lütfen bir numara giriniz");
            }
            else
            {
                DialogResult result = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Evet-Hayır", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int sayi;
                    if (int.TryParse(numara_kontrol.Text, out sayi))
                    {
                        l.Sil(Convert.ToInt32(numara_kontrol.Text));
                        numara_kontrol.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen sayılardan oluşan numara giriniz.");
                    }
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Kayıt silinmedi!");
                }
            }
        }
        private void kontrol_ekleme_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numara_kontrol.Text))
            {
                MessageBox.Show("Lütfen bir numara giriniz");
            }
            else
            {
                int sayi;
                if (int.TryParse(numara_kontrol.Text, out sayi))
                {
                    if (l.Kontrol(Convert.ToInt32(numara_kontrol.Text)) == true)
                    {
                        MessageBox.Show(numara_kontrol.Text + " numaraya sahip " + "\nkayıtlı öğrenci bulunmaktadır!\nLütfen numaranızı kontrol ediniz!");
                        ogrenci_listesi.Hide();
                        bilgiler2.Hide();
                    }
                    else
                    {
                        bilgiler2.Show();
                        bilgiler2.BringToFront();
                        ogrenci_listesi.Hide();
                        panel2.Hide();
                        numaratxt.Text = numara_kontrol.Text;
                        numara_kontrol.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen sayılardan oluşan numara giriniz.");
                }
            }
        }
        private void ana_ekrana_don_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel2.BringToFront();
            bilgiler2.Hide();
            ogrenci_listesi.Hide();
        }
        private void bilgiler2_Load(object sender, EventArgs e){}
        private void liste_Click(object sender, EventArgs e)
        {
            bilgiler2.Hide();
            panel2.Hide();
            ogrenci_listesi.Show();
            ogrenci_listesi.BringToFront();
            l.Yazdır(dataGridView1);
        }

        private void göster_Click(object sender, EventArgs e)
        {
            l.Yazdır(dataGridView1);
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(adtxt.Text))
            {
                MessageBox.Show("Lütfen Adınızı giriniz!");
            }
            else if (string.IsNullOrEmpty(soyadtxt.Text))
            {
                MessageBox.Show("Lütfen Soyadınızı giriniz!");
            }
            else
            {
                int sayi;
                if (int.TryParse(numaratxt.Text, out sayi))
                {
                    l.ekle(adtxt.Text, soyadtxt.Text, Convert.ToInt32(numaratxt.Text), bolumtxt.Text, adrestxt.Text);
                    adtxt.Clear();
                    soyadtxt.Clear();
                    bolumtxt.Clear();
                    adrestxt.Clear();
                    numaratxt.Clear();
                }
                else
                {
                    MessageBox.Show("Lütfen sayılardan oluşan numara giriniz.");
                }
            }
        }
    }
}
