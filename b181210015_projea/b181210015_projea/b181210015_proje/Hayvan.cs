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

    abstract class Hayvan
    {
        public static int kasa;

        public Hayvan()
        {
            kasa = 0;
        }

        abstract public void YemVer();
        abstract public void UrunUret();
        abstract public bool EnerjiTuketimi();
        abstract public void Sat();
    }
}
