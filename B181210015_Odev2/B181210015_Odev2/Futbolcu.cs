using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B181210015_Odev2
{
    class Futbolcu
    {
        private string adSoyad;

        private byte formaNo;
        private byte hiz;
        private byte kararlilik;
        private byte dayaniklilik;
        private byte pas;
        private byte sut;
        private byte yetenek;
        private byte dogalForm;
        private byte sans;

        private byte golSkorLimit;
        private byte pasSkorLimit;

        //public string AdSoyad               { get { return adSoyad; } }

        //public byte FormaNo                 { get { return formaNo; } }
        public byte Hiz                     { get { return hiz; } }
        public byte Kararlilik              { get { return kararlilik; } }
        public byte Dayaniklilik            { get { return dayaniklilik; } }
        public byte Pas                     { get { return pas; } }
        public byte Sut                     { get { return sut; }   }
        public byte Yetenek                 { get { return yetenek; } }
        public byte DogalForm               { get { return dogalForm; } }
        public byte Sans                    { get { return sans; } }

        public byte GolSkorLimit            { get { return golSkorLimit; } }
        public byte PasSkorLimit            { get { return pasSkorLimit; } }


        //Kurucu fonksiyon içinde rastgele değer atamaları yapıldı. Basarılı gol ve pas skorları ilgili degiskenlere atandı.
        public Futbolcu(string adSoyad, byte formaNo)
        {
            this.adSoyad = adSoyad;
            this.formaNo = formaNo;

            Random rastgele = new Random();

            hiz = Convert.ToByte(rastgele.Next(50, 101));
            kararlilik = Convert.ToByte(rastgele.Next(50, 101));
            dayaniklilik = Convert.ToByte(rastgele.Next(50, 101));
            pas = Convert.ToByte(rastgele.Next(50, 101));
            sut = Convert.ToByte(rastgele.Next(50, 101));
            yetenek = Convert.ToByte(rastgele.Next(50, 101));
            dogalForm = Convert.ToByte(rastgele.Next(50, 101));
            sans = Convert.ToByte(rastgele.Next(50, 101));

            golSkorLimit = 70;
            pasSkorLimit = 60;

        }

        //PasVer methoduyla ilgili skor hesaplamaları yapıldı. Verilen pasın basarılı olup olmadıgı kontrol edildi.
        public virtual bool PasVer()
        {
            float pasSkor = (float)(pas * 0.3) + (float)(yetenek * 0.3) + (float)(dayaniklilik * 0.1) + (float)(dogalForm * 0.1) + (float)(sans * 0.2);

            if (pasSkor > pasSkorLimit)
                return true;
            else
                return false;

        }

        //GolVurusu methoduyla ilgili skor hesaplamaları yapıldı. Vurusun basarili olup olmadıgı kontrol edildi.
        public virtual bool GolVurusu()
        { 
            float golSkor = (float)(yetenek * 0.3) + (float)(sut * 0.2) + (float)(kararlilik * 0.1) + (float)(dogalForm * 0.1) + (float)(hiz * 0.1) + (float)(sans * 0.2);

            if (golSkor > golSkorLimit)
                return true;
            else
                return false;
        }
    }
}
