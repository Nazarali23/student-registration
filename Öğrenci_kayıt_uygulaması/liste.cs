using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace liste_ekle_çıkar
{
    public class Liste
    {
        Dugum head;
        Dugum tail;
        public Liste() 
        {
            head = null;
            tail = null;
        }
        public void ekle(string ad, string soyad, int numara, string bolum, string adres)
        {
            Dugum yeni = new Dugum(ad, soyad, numara, bolum, adres);

            if (head == null)
            {
                head = tail = yeni;
                MessageBox.Show("Yeni Öğrenci kaydedildi!");
            }
            else
            {
                if (Kontrol(numara) == false)
                {
                    Dugum temp = head;
                    while (temp.next != null && temp.Numara > temp.next.Numara)
                    {
                        temp = temp.next;
                    }

                    // Yeni düğüm, bulunan konumun önüne eklenir
                    if (temp == head && temp.Numara > numara) // Başlangıca ekleme
                    {
                        yeni.next = head;
                        head.prev = yeni;
                        head = yeni;
                        MessageBox.Show("Yeni Öğrenci kaydedildi!");
                    }
                    else
                    {
                        yeni.next = temp.next;
                        if (temp.next != null) // Ortaya veya sona ekleme
                        {
                            temp.next.prev = yeni;
                            MessageBox.Show("Yeni Öğrenci kaydedildi!");
                        }
                        else // Sona ekleme
                        {
                            tail = yeni;
                            MessageBox.Show("Yeni Öğrenci kaydedildi!");
                        }
                        temp.next = yeni;
                        yeni.prev = temp;
                        MessageBox.Show("Yeni Öğrenci kaydedildi!");
                    }
                }
                else
                {
                    MessageBox.Show("Bu numara ait kayıtlı öğrenci mevcut!");
                }
            }
        }
        public void Sil(int numara)
        {
            if (head == null)
            {
                MessageBox.Show("Liste boş, silme işlemi yapılamadı!");
            }
            else
            {
                Dugum temp = head;
                if (head.Numara == numara)        // Eğer silinecek düğüm baş düğümse
                {
                    head = head.next;
                    MessageBox.Show("Kayıtlı öğrenci silindi!");
                }
                else                              // Eğer silinecek düğüm baş düğüm değilse
                {
                    while (temp != null && temp.Numara != numara)
                    {
                        temp = temp.next;
                    }
                    if (temp != null)
                    {
                        temp.prev.next = temp.next;  // Silinen düğümün önceki ve sonraki düğümleri birbirine bağlanır
                        if (temp.next != null)
                        {
                            temp.next.prev=temp.prev;
                            MessageBox.Show("Kayıtlı öğrenci silindi!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Silinecek değer listede bulunamadı! Lütfen tekrar kontrol ediniz!");
                    }
                }
            }
        }
        public void Yazdır(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear(); // DataGridView'i temizle
            Dugum temp = head;
            while (temp != null)
            {
                // Yeni bir satır oluştur
                DataGridViewRow row = new DataGridViewRow();

                // Satıra hücreler ekle
                row.Cells.Add(new DataGridViewTextBoxCell { Value = temp.Ad });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = temp.Soyad });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = temp.Numara });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = temp.Bolum });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = temp.Adres });

                // Satırı DataGridView'e ekle
                dataGridView.Rows.Add(row);
                temp = temp.next;
            }
        }
        public bool Kontrol(int numara)
        {    
            Dugum temp = head;
               while(temp != null)
            {
                if( temp.Numara == numara ) { return true; }
                temp = temp.next;
            }
            return false;
        }
    }
}
