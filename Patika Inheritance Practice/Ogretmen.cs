using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patika_Inheritance_Practice
{
    public class Ogretmen : BaseKisi // Oluşturdumuz Öğretmen classına ":" kullanarak BaseKisi classımı Miras alıyoruz
    {
        public int Maaş { get; set; } // Öğretmenin maaşı için oluşturduk

        public void OgretmenYazdır()
        {
            Console.WriteLine($"Maaş : {Maaş}"); // Maaşı Yazdırıyoruz.
            BaseYazdır(); // Base Classında oluşturdumuz bilgileri yazdırdık.
        }
    }
}