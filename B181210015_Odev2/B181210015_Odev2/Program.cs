using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B181210015_Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Futbolcu listesi olusturularak futbolcular eklendi.
            List<Futbolcu> Takim = new List<Futbolcu>();

            Takim.Add(new Futbolcu("Mert Gunok", 1));

            Takim.Add(new Defans("Zeki Celik", 2));
            Takim.Add(new Defans("Mehmet Topal", 3));
            Takim.Add(new Defans("Hamit Altintop", 4));
            Takim.Add(new Defans("Bulent Korkmaz", 5));

            Takim.Add(new OrtaSaha("Emre Belezoglu", 6));
            Takim.Add(new OrtaSaha("Kaan Ayhan", 7));
            Takim.Add(new OrtaSaha("Gokhan Gonul", 8));
            Takim.Add(new OrtaSaha("Burak Yilmaz", 9));

            Takim.Add(new Forvet("Cenk Tosun", 10));
            Takim.Add(new Forvet("Oguz Cetin", 11));

            int formaNo;
            bool gololabilir = true;
            Random rastgele = new Random();

            //Pas verme gerceklestiriliyor.
            for (int i = 1; i <= 3; i++)
            {
                
                formaNo = rastgele.Next(1, 11);
                Console.WriteLine("{0}. pas {1} numarali futbolcuda.", i + 1, formaNo);

                if (!Takim[formaNo].PasVer())
                {
                    Console.WriteLine("Pas basarisiz.");
                    gololabilir = false;
                    break;
                }
            }


                if (gololabilir)
                {
                    formaNo = rastgele.Next(1, 11);
                    if (Takim[formaNo].GolVurusu());
                    {
                        Console.WriteLine("GOOOOOOOL!");
                        Console.ReadLine();
                    }
                }

                else
                {
                    Console.WriteLine("Gol gerceklesmedi.");
                }
                
            

        }
    }
}
