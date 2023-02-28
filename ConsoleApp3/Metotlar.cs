using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     class Metotlar
    {
        public void metin()
        {
            Console.WriteLine("Merhaba dünya");
            Console.WriteLine("Merhaba muhammet");
        }
        public void kisi1()
        {
            for (int i=1; i<=5; i++)
            {
                Console.WriteLine(i+ ".Kişi");
            }
        }
        public void kisi2(string ad)        // ad adında değişken oluşturduk değişken kod ile yada ekrandan alıp yazdırdık 
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i + ad);
            }
        }
        public void kisi3(string ad,string soyad, int yas, string meslek)
        {
            Console.WriteLine("Adınız :" + ad + "\n" + "Soyadınız :" + soyad + "\n" + "Yaşınız :" + yas + "\n" + "Mesleği :" + meslek);
        }

        public int toplama(int s1, int s2)
        {
            int s3 = s1 + s2;
            Console.WriteLine(s3);
            return s3;
        }
    }
}
