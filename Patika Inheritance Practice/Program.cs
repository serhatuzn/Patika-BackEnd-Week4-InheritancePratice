using Patika_Inheritance_Practice;

Ogrenci ogrenci = new Ogrenci(); // Öğrenci classından öğrenciyi oluşturup hakkında bilgileri oluşturuyoruz.
{
    ogrenci.OgrNO = 185;
    ogrenci.Ad = "Serhat";
    ogrenci.Soyad = "Uzun";
}

Ogretmen ogretmen = new Ogretmen(); // Ögretmen classından öğretmeni oluşturup hakkında bilgileri oluşturuyoruz.
{
    ogretmen.Maaş = 100000;
    ogretmen.Ad = "Elif Nur";
    ogretmen.Soyad = "Kaya";
}

// Ogrenciye dair bilgileri Ekrana yazdırma.
Console.WriteLine("*Öğrenci Bilgileri*");
ogrenci.OgrenciYazdır();
Console.WriteLine("-----------------------------------------------");
// Ogretmene dair bilgileri Ekrana yazdırma.
Console.WriteLine("*Öğretmen Bilgileri*");
ogretmen.OgretmenYazdır();
