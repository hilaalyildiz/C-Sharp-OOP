/****************************************************************************
**					       SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ
**					       2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: HİLAL YILDIZ
**				ÖĞRENCİ NUMARASI.......: B181210015
**              DERSİN ALINDIĞI GRUP...: 1A
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace B181210015_1.ODEV_1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_dosyasec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            if (openFile1.ShowDialog() == DialogResult.OK)
                richTextBox_bilgiler.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            // Richtextbox'taki bilgiler kullanılmak üzere hepsi degiskenine atanıyor.
            string hepsi = richTextBox_bilgiler.Text;

            // Metin dosyasındaki veri satırlara ayrılıyor. 
            string[] satirlar = hepsi.Split('\n');
            string[] kelimeler;

            bool personel = false;

            // Metin dosyasındaki satır sayısı kadar dönecek bir döngü oluşturuldu.
            for (int i = 0; i < satirlar.Length; i++)
            {
                // Her bir satırı boşluklara göre parçalıyoruz.
                kelimeler = satirlar[i].Split(' ');

                // Textbox'tan alınan veri metin dosyasındaki ile karşılaştırılıyor.
                if (kelimeler[0] == textBox_tc.Text)
                {
                    //CalisanBilgileri sinifinin calisan nesnesi olusturuldu.
                    CalisanBilgileri calisan = new CalisanBilgileri();

                    // Kelimeler dizisinin her bir elemanı gerekli dönüşümler yapılarak calısan nesnesinin 
                    // ilgili degiskenlerine atanıyor.
                    calisan.Tc = kelimeler[0];
                    calisan.Ad = kelimeler[1];
                    calisan.Soyad = kelimeler[2];
                    calisan.Yas = byte.Parse(kelimeler[3]);
                    calisan.Calismasure = int.Parse(kelimeler[4]);
                    calisan.Medenihal = kelimeler[5];
                    calisan.Calisiyormu = kelimeler[6];
                    calisan.Cocuksayisi = byte.Parse(kelimeler[7]);
                    calisan.Tabanmaas = float.Parse(kelimeler[8]);
                    calisan.Makamtazminati = float.Parse(kelimeler[9]);
                    calisan.Idarigorevtazminati = float.Parse(kelimeler[10]);
                    calisan.Fazlamesaisaati = int.Parse(kelimeler[11]);
                    calisan.Fazlamesaiucreti = float.Parse(kelimeler[12]);
                    calisan.Vergimatrahi = float.Parse(kelimeler[13]);
                    calisan.Personelfotograf = kelimeler[14];
                    // calisan.Maas = float.Parse(kelimeler[14]);

                    // Calisan nesnesinin ilgili desigkenleri labellara atanıyor.
                    label_ad.Text = calisan.Ad;
                    label_soyad.Text = calisan.Soyad;
                    label_yası.Text = calisan.Yas.ToString();
                    label_calismasure.Text = calisan.Calismasure.ToString();
                    label_medenihal.Text = calisan.Medenihal.ToString();
                    label_calisiyormu.Text = calisan.Calisiyormu.ToString();
                    label_cocuksayisi.Text = calisan.Cocuksayisi.ToString();
                    label_tabanmaas.Text = calisan.Tabanmaas.ToString();
                    label_makamtazminati.Text = calisan.Makamtazminati.ToString();
                    label_idarigrvtazmnt.Text = calisan.Idarigorevtazminati.ToString();
                    label_fazlamesaisa.Text = calisan.Fazlamesaisaati.ToString();
                    label_fazlamesaiucr.Text = calisan.Fazlamesaiucreti.ToString();
                    label_vergimatrahi.Text = calisan.Vergimatrahi.ToString();

                    try
                    {
                        pictureBox1.Load(calisan.Personelfotograf);
                    }
                    catch
                    {
                        MessageBox.Show("Fotograf bulunamadi");
                    }

                    // Calisan nesnesdeki hesaplama fonksiyonları yardımıyla gerekli hesaplamalar yapılıp
                    // dönüşümler yapıldıktan sonra ilgili labellara atanıyor.
                    label_burutmaas.Text = Convert.ToString(calisan.BurutMaas());
                    label_damgavergisi.Text = Convert.ToString(calisan.DamgaVergisi());
                    label_gelirvergisi.Text = Convert.ToString(calisan.EmekliKesintisi());
                    label_emeklikesintisi.Text = Convert.ToString(calisan.EmekliKesintisi());
                    label_netmaas.Text = Convert.ToString(calisan.NetMaas());

                    personel = true;

                }
            }

            if (personel == false)
            {
                MessageBox.Show(textBox_tc.Text + " Tc numarali bir personel bulunamadi.");
            }

        }
    }
}
