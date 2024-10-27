using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patika_Inheritance_Practice
{
    public class Ogrenci : BaseKisi
    {
        public int OgrNO { get; set; } // Öğrencinin Sınıf no'su için oluşturduk

        public void OgrenciYazdır()
        {
            Console.WriteLine($"Öğrenci No : {OgrNO}"); // Öğrenicnin Sınıf No'sunu Yazdırdık.
            BaseYazdır(); // Base classını Yazdırdık.
        }
    }
}