using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B181210015_Odev2
{
    class Defans:Futbolcu
    {
        private byte pozisyonAlma;
        private byte kafa;
        private byte sicrama;

        public byte PozisyonAlma              { get { return pozisyonAlma; } }
        public byte Kafa                      { get { return kafa; } }
        public byte Sicrama                   { get { return sicrama; } }


        //Kurucu fonksiyon içinde rastgele deger atamaları yapıldı.
        public Defans(string adSoyad, byte formaNo):base(adSoyad,formaNo)
        {
            Random rastgele = new Random();

            pozisyonAlma = Convert.ToByte(rastgele.Next(50, 91));
            kafa = Convert.ToByte(rastgele.Next(50, 91));
            sicrama = Convert.ToByte(rastgele.Next(50, 91));
        }


        //PasVer methoduyla ilgili skor hesaplamaları yapıldı. Verilen pasın basarılı olup olmadıgı kontrol edildi.
        public override bool PasVer()
        {
            float pasSkor = (float)(Pas * 0.3) + (float)(Yetenek * 0.3) + (float)(Dayaniklilik * 0.1) + (float)(DogalForm * 0.1) + 
                            (float)(pozisyonAlma * 0.1) + (float)(Sans * 0.2);

            if (pasSkor > PasSkorLimit)
                return true;
            else
                return false;
        }


        //GolVurusu methoduyla ilgili skor hesaplamaları yapıldı. Vurusun basarılı olup olmadıgı kontrol edildi.
        public override bool GolVurusu()
        {
            float golSkor = (float)(Yetenek * 0.3) + (float)(Sut * 0.2) + (float)(Kararlilik * 0.1) + (float)(DogalForm * 0.1) + 
                            (float)(kafa * 0.1) +(float)(sicrama*0.1)+(float)(Sans * 0.2);

            if (golSkor > GolSkorLimit)
                return true;
            else
                return false;
        }
    }
}
