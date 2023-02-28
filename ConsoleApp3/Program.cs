using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metotlar Msj = new Metotlar();  
            //Msj.metin();


            //Metotlar ks1 = new Metotlar();
            //ks1.kisi1();

            //Metotlar ks2 = new Metotlar();
            //ks2.kisi2("muhammet");


            //string isim;                    // Değişken tanımladık 
            //Console.Write("İsim Girin:");
            //isim = Console.ReadLine();      //Değişkene Ekrandan yazı aldık
            //ks2.kisi2(isim);                //Aldığımız yazıyı metot ile ekrana 5 kez yazdırdık        



            //Metotlar ks3 = new Metotlar();            
            //string adı, soyadı, meslek;
            //int yas;
            //Console.Write("Adı Girin:");
            //adı = Console.ReadLine();
            //Console.Write("Soyad Girin:");
            //soyadı = Console.ReadLine();
            //Console.Write("Yaş Girin:");
            //yas = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Meslek Girin:");
            //meslek = Console.ReadLine();
            //ks3.kisi3(adı,soyadı,yas,meslek); 


            //Metotlar islem = new Metotlar();
            //int say1, say2;
            //Console.Write("ilk sayıyı girin :");
            //say1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayıyı girin :");
            //say2= Convert.ToInt32(Console.ReadLine());
            //islem.toplama(say1, say2);



            //string adı, soyadı, meslek;  //Constructor yapısı için yaptım metotu class ta oluşturup direk kullandık 
            //adı = Console.ReadLine();       // tam emin değilim ama class ismi ile metotun ismi aynı olmalı 
            //soyadı = Console.ReadLine();
            //meslek = Console.ReadLine();
            //bilgiler bilgi = new bilgiler(adı, soyadı, meslek);


            Kimlik kml = new Kimlik();
            kml.AD = "MUHAMMET";
            kml.SOYAD = "dicel";
            kml.MEMLEKET = "Giresun";
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);




            Console.Read();

        }
    }
}


// Console.WriteLine("Ekrana Yazdırma");   Ekrana Yazı yazdırma
// Console.Write("Ekrana Yazdırma");   Line satır aşapıya inmeyi sağlar Console.Write yazdığında yanından yazmaya devam eder
//Console.ReadLine();  Ekrandan yazı almayı sağlar