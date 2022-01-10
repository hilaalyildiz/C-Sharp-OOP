/****************************************************************************
**					       SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ
**					       2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3
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

namespace _1a_b181210015_odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_hesapla_Click(object sender, EventArgs e)
        {
            // Girilen deger bosluk degilse islem yapılıyor.
            if (textBox_islem.Text != "")
            {
                double sonuc = Convert.ToDouble(new DataTable().Compute(textBox_islem.Text, null));
                textBox_sonuc.Text = (sonuc.ToString());
            }
            else
                MessageBox.Show("Bir islem giriniz.");
        }

        //İslem ve sonuc textboxındaki değerler temizlendi.
        private void button_sil_Click(object sender, EventArgs e)
        {
            textBox_islem.Clear();
            textBox_sonuc.Clear();
        }
    }
}
