using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B181210015_Odev2
{
    class Forvet:Futbolcu
    {
        private byte bitiricilik;
        private byte ilkDokunus;
        private byte kafa;
        private byte ozelYetenek;
        private byte sogukKanlilik;
        
        public byte Bitiricilik         { get { return bitiricilik; } }
        public byte IlkDokunus          { get { return ilkDokunus; } }
        public byte Kafa                { get { return kafa; } }
        public byte OzelYetenek         { get { return ozelYetenek; } }
        public byte SogukKanlilik       { get { return sogukKanlilik; } }


        //Kurucu fonksiyon içinde rastgele değer atamaları yapıldı.
        public Forvet(string adSoyad, byte formaNo):base (adSoyad,formaNo)
        {
            Random rastgele = new Random();

            bitiricilik = Convert.ToByte(rastgele.Next(70, 101));
            ilkDokunus = Convert.ToByte(rastgele.Next(70, 101));
            kafa = Convert.ToByte(rastgele.Next(70, 101));
            ozelYetenek = Convert.ToByte(rastgele.Next(70, 101));
            sogukKanlilik = Convert.ToByte(rastgele.Next(70, 101));
        }

        //GolVurusu methoduyla ilgili skor hesaplamaları yapıldı. Vurusun basarili olup olmadıgı kontrol edildi.
        public override bool GolVurusu()
        {
            float golSkor = (float)(Yetenek * 0.2) + (float)(ozelYetenek * 0.2) + (float)(ilkDokunus * 0.1) + (float)(Sut * 0.1) + 
                            (float)(Kararlilik * 0.1) + (float)(Kafa * 0.1) +(float)(SogukKanlilik * 0.1) + (float)(bitiricilik * 0.1) +
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
                            (float)(DogalForm * 0.1) + (float)(Sans * 0.1);

            if (pasSkor > PasSkorLimit)
                return true;
            else
                return false;
        }

    }
}
