using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;

            if (sicaklik<=(int)HavaDurumu.soğuk)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekleyelim");
            }else if (sicaklik <= (int)HavaDurumu.normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim");
            }else if(sicaklik <= (int)HavaDurumu.sıcak)
            {
                Console.WriteLine("Dışarıya çıkabiliriz.");
            }else if(sicaklik >= (int)HavaDurumu.çoksıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın soğumasını bekleyelim");
            }
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        soğuk=5,
        normal=20,
        sıcak=25,
        çoksıcak=30
    }
}
