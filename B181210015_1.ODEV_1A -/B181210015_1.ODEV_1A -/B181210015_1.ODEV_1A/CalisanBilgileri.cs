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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B181210015_1.ODEV_1A
{
    // Calısan bilgilerini ve gerekli hesaplamaları içeren sınıf.
    class CalisanBilgileri
    {
        // üye degisken tanımlamaları yapıldı.
        private string tc;
        private string ad;
        private string soyad;
        private float maas;
        private byte yas;
        private int calismasure;
        private string medenihal;
        private string calisiyormu;
        private byte cocuksayisi;
        private float tabanmaas;
        private float makamtazminati;
        private float idarigorevtazminati;
        private int fazlamesaisaati;
        private float fazlamesaiucreti;
        private float vergimatrahi;
        private string personelfotograf;
        private double gelirvergisi;



        public string Tc                             { get { return tc; }                          set { tc = value; } }
        public string Ad                             { get { return ad; }                          set { ad = value; } }
        public string Soyad                          { get { return soyad; }                       set { soyad = value; } }
        public float Maas                            { get { return maas; }                        set { maas = value; } }
        public byte Yas                              { get { return yas; }                         set { yas = value; } }
        public int Calismasure                       { get { return calismasure; }                 set { calismasure = value; } }
        public string Medenihal                      { get { return medenihal; }                   set { medenihal = value; } }
        public string Calisiyormu                    { get { return calisiyormu; }                 set { calisiyormu = value; } }
        public byte Cocuksayisi                      { get { return cocuksayisi; }                 set { cocuksayisi = value; } }
        public float Tabanmaas                       { get { return tabanmaas; }                   set { tabanmaas = value; } }
        public float Makamtazminati                  { get { return makamtazminati; }              set { makamtazminati = value; } }
        public float Idarigorevtazminati             { get { return idarigorevtazminati; }         set { idarigorevtazminati = value; } }
        public int Fazlamesaisaati                   { get { return fazlamesaisaati; }             set { fazlamesaisaati = value; } }
        public float Fazlamesaiucreti                { get { return fazlamesaiucreti; }            set { fazlamesaiucreti = value; } }
        public float Vergimatrahi                    { get { return vergimatrahi; }                set { vergimatrahi = value; } }
        public string Personelfotograf               { get { return personelfotograf; }            set { personelfotograf = value; } }

        // Burut maas hesaplaması yapılıyor.
        public float BurutMaas()
        {
            float burutMaas = 0;

            if (medenihal == "Bekar")
                burutMaas = tabanmaas + makamtazminati + idarigorevtazminati + cocuksayisi * 30 + fazlamesaisaati * fazlamesaiucreti;

            else if (medenihal == "Evli" && calisiyormu == "Evet")
                burutMaas = tabanmaas + makamtazminati + 200 + idarigorevtazminati + cocuksayisi * 30 + fazlamesaisaati * fazlamesaiucreti;

            else if (medenihal == "Evli" && calisiyormu == "Hayır")
                burutMaas = tabanmaas + makamtazminati + idarigorevtazminati + cocuksayisi * 30 + fazlamesaisaati * fazlamesaiucreti;

            return burutMaas;
        }

        // Damga vergisi hesaplaması yapılıyor.
        public double DamgaVergisi()
        {
            return BurutMaas() * 10 / 100;
        }

        // Gelir vergisi hesaplaması yapılıyor.
        public double GelirVergisi()
        {
            if (vergimatrahi < 10000)
                gelirvergisi = BurutMaas() * 15 / 100;
            else if (10000 <= vergimatrahi && vergimatrahi < 20000)
                gelirvergisi = BurutMaas() * 20 / 100;
            else if (20000 <= vergimatrahi && vergimatrahi < 30000)
                gelirvergisi = BurutMaas() * 25 / 100;
            else if (30000 <= vergimatrahi)
                gelirvergisi = BurutMaas() * 30 / 100;

            return gelirvergisi;
        }

        // Emekli kesintisi hesaplaması yapılıyor.
        public double EmekliKesintisi()
        {
            return BurutMaas() * 15 / 100;
        }

        // Net maas hesaplaması yapılıyor.
        public double NetMaas()
        {
            return BurutMaas() - (EmekliKesintisi() + GelirVergisi() + DamgaVergisi());
        }


    }
}
