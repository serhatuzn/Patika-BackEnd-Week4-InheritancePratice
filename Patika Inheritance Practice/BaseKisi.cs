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
}