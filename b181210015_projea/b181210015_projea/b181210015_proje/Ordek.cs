
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace b181210015_proje
{
    class Ordek : Hayvan
    {
        // Gerekli degiskenler olusturuldu.
        private bool canlilik;
        private bool sesCıktıMı;
        private string sesDosyasi;
        private int enerji;
        
        public int Enerji
        {
            get { return enerji; }
            set { enerji = value; }
        }

        public int toplamUrun;

        // Kurucu fonksiyon içinde ilk deger atamaları yapıldı.
        public Ordek(string sesDosyasi)
        {
            canlilik = true;
            sesCıktıMı = false;
            toplamUrun = 0;
            enerji = 100;

            this.sesDosyasi = sesDosyasi;
        }

        // Canlılığı kontrol edecegimiz Enerji Tuketim fonksiyonu olusturuldu.
        public override bool EnerjiTuketimi()
        {
            if (canlilik)
            {
                enerji -= 2;
            }

            if (enerji < 1 & sesCıktıMı == false)
            {
                enerji = 0;
                canlilik = false;

                SoundPlayer Ses = new SoundPlayer();
                Ses.SoundLocation = sesDosyasi;
                Ses.Play();
                sesCıktıMı = true;
            }

            return canlilik;
        }

        // Belirli zaman aralıklarında üretecegimiz ürünler için Urun Uretme fonksiyonu olusturuldu.
        public override void UrunUret()
        {
            if (canlilik)
            {
                if (Form_HayvanCiftligi.sayac % 5 == 0)
                {
                    toplamUrun++;
                }
            }
        }

        // Sat fonksiyonu olusturuldu.
        public override void Sat()
        {
            if (toplamUrun > 0)
            {
                kasa += 3 * toplamUrun;
                toplamUrun = 0;
            }
        }

        // Yem Ver fonksiyonu olusturuldu.
        public override void YemVer()
        {
            enerji = 100;
        }
    }
}

