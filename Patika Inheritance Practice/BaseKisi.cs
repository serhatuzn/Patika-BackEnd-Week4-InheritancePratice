using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patika_Inheritance_Practice
{
    public class BaseKisi
    {
        // burda hem öğretmende hem öğrencide kullanacağımız bilgileri oluşturuyoruz
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void BaseYazdır()
        {
            Console.WriteLine($"Ad: {Ad} \r\nSoyad: {Soyad}"); // Ad soyad şeklinde Yazdırıyoruz
        }
    }

    public class Ogrenci : BaseKisi
    {
        public int OgrNO { get; set; } // Öğrencinin Sınıf no'su için oluşturduk

        public void OgrenciYazdır()
        {
            Console.WriteLine($"Öğrenci No : {OgrNO}"); // Öğrenicnin Sınıf No'sunu Yazdırdık.
            BaseYazdır(); // Base classını Yazdırdık.
        }
    }

    public class Ogretmen : BaseKisi
    {
        public int Maaş { get; set; } // Öğretmenin maaşı için oluşturduk

        public void OgretmenYazdır()
        {
            Console.WriteLine($"Maaş : {Maaş}"); // Maaşı Yazdırıyoruz.
            BaseYazdır(); // Base Classında oluşturdumuz bilgileri yazdırdık.
        }
    }
}