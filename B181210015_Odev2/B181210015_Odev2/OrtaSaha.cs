using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B181210015_Odev2
{
    class OrtaSaha:Futbolcu
    {
        private byte uzunTop;
        private byte ilkDokunus;
        private byte uretkenlik;
        private byte topSurme;
        private byte ozelYetenek;

        public byte UzunTop               { get { return uzunTop; } }
        public byte IlkDokunus            { get { return ilkDokunus; } }
        public byte Uretkenlik            { get { return uretkenlik; } }
        public byte TopSurme              { get { return topSurme; } }
        public byte OzelYetenek           { get { return ozelYetenek; } }


        //Kurucu fonksiyon içinde rastgele deger atamaları yapıldı.
        public OrtaSaha(string adSoyad, byte formaNo) :base(adSoyad, formaNo)
        {
            Random rastgele = new Random();

            uzunTop = Convert.ToByte(rastgele.Next(60, 101));
            ilkDokunus = Convert.ToByte(rastgele.Next(60, 101));
            uretkenlik = Convert.ToByte(rastgele.Next(60, 101));
            topSurme = Convert.ToByte(rastgele.Next(60, 101));
            ozelYetenek = Convert.ToByte(rastgele.Next(60, 101));

        }


        //GolVurusu methoduyla ilgili skor hesaplamaları yapıldı. Vurusun basarili olup olmadıgı kontrol edildi.
        public override bool GolVurusu()
        { 
           float golSkor = (float)(Yetenek * 0.3) + (float)(ozelYetenek*0.2)+(float)(ilkDokunus*0.1)+(float)(Sut * 0.2) + (float)(Kararlilik * 0.1) + 
                           (float)(DogalForm * 0.1) + (float)(Sans * 0.1);

            if (golSkor > GolSkorLimit)
                return true;
            else
                return false;
        }


        //PasVer methoduyla ilgili skor hesaplamaları yapıldı. Verilen pasın basarılı olup olmadıgı kontrol edildi.
        public override bool PasVer()
        {
            float pasSkor = (float)(Pas * 0.3) + (float)(Yetenek * 0.2) + (float)(ozelYetenek * 0.2) + (float)(Dayaniklilik * 0.1) +
                            (float)(DogalForm * 0.1) + (float)(uzunTop * 0.1) + (float)(topSurme * 0.1) + (float)(Sans * 0.1);

            if (pasSkor > PasSkorLimit)
                return true;
            else
                return false;
        }
    }
}
