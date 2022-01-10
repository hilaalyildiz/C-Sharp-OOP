/****************************************************************************
**					       SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ
**					       2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: proje
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

namespace b181210015_proje
{
    public partial class Form_HayvanCiftligi : Form
    {
        public Form_HayvanCiftligi()
        {
            InitializeComponent();
        }

        public static int sayac = 0;

        Inek inek = new Inek(Application.StartupPath + "//Ses Dosyaları//inek.wav");
        Keci keci = new Keci(Application.StartupPath + "//Ses Dosyaları//keci.wav");
        Ordek ordek = new Ordek(Application.StartupPath + "//Ses Dosyaları//ordek.wav");
        Tavuk tavuk = new Tavuk(Application.StartupPath + "//Ses Dosyaları//tavuk.wav");

        private void timer_GecenSure_Tick(object sender, EventArgs e)
        {
            sayac++;
            label_Saniye.Text = sayac.ToString()+ " SN";

            if (tavuk.EnerjiTuketimi() == false)
            {
                label_TavukDurum.Text = "ÖLÜ";
            }
            progressBar_TavukEnerji.Value = tavuk.Enerji;

            tavuk.UrunUret();
            label_TavukYumurtasiAdet.Text = tavuk.toplamUrun.ToString() + " Adet";

            

            if (inek.EnerjiTuketimi()==false)
            {
                label_InekDurum.Text = "ÖLÜ";
            }
            progressBar_InekEnerji.Value = inek.Enerji;

            inek.UrunUret();
            label_InekSutuLitre.Text = inek.toplamUrun.ToString() + " LİTRE";


            if (ordek.EnerjiTuketimi()== false)
            {
                label_OrdekDurum.Text = "ÖLÜ";
            }
            progressBar_OrdekEnerji.Value = inek.Enerji;

            ordek.UrunUret();
            label_OrdekYumurtasiAdet.Text = ordek.toplamUrun.ToString() + " Adet";

            if (keci.EnerjiTuketimi()==false)
            {
                label_KeciDurum.Text = "ÖLÜ";
            }
            progressBar_KeciEnerji.Value = keci.Enerji;

            keci.UrunUret();
            label_KeciSutuLitre.Text = keci.toplamUrun.ToString()+ " LİTRE";
        }

        private void Form_HayvanCiftligi_Load(object sender, EventArgs e)
        {
            progressBar_TavukEnerji.Value = tavuk.Enerji;
            progressBar_OrdekEnerji.Value = ordek.Enerji;
            progressBar_InekEnerji.Value = inek.Enerji;
            progressBar_KeciEnerji.Value = keci.Enerji;
        }

        private void button_TavukYumurtasiSat_Click(object sender, EventArgs e)
        {
            tavuk.Sat();
            label_TL.Text = Hayvan.kasa.ToString() + " TL";
        }

        private void buttonOrdekYumurtasiSat_Click(object sender, EventArgs e)
        {
            ordek.Sat();
            label_TL.Text = Hayvan.kasa.ToString()+ " TL";

        }

        private void button_InekSutuSat_Click(object sender, EventArgs e)
        {
            inek.Sat();
            label_TL.Text = Hayvan.kasa.ToString()+ " TL";

        }

        private void button_KeciSutuSat_Click(object sender, EventArgs e)
        {
            keci.Sat();
            label_TL.Text = Hayvan.kasa.ToString () + " TL";

        }



        private void button_TavukYemVer_Click(object sender, EventArgs e)
        {
            tavuk.YemVer();
        }

        private void button_OrdekYemVer_Click(object sender, EventArgs e)
        {
            ordek.YemVer();
        }

        private void button_InekYemVer_Click(object sender, EventArgs e)
        {
            inek.YemVer();
        }

        private void button_KeciYemVer_Click(object sender, EventArgs e)
        {
            keci.YemVer();
        }
    }
}
