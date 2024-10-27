# 📋 Inheritance Practice Proje Açıklaması

Bu proje, C# dilinde **kalıtım (inheritance)** kavramını göstermektedir. Amaç, **`BaseKisi`** isimli bir temel sınıf oluşturarak ortak özellikler ve metotlar tanımlamaktır. Bu temel sınıftan türetilen **`Ogrenci` (Öğrenci)** ve **`Ogretmen` (Öğretmen)** sınıfları, ek özellik ve metotlar ile bu işlevselliği genişletir. Bu örnek, **kod tekrarını azaltarak** kalıtım yoluyla nasıl daha düzenli yazılım geliştirilebileceğini gösterir.

---

## 📂 Sınıfların Genel Yapısı

1. **`BaseKisi`** (Temel Sınıf)  
   - **Özellikler**:  
     - `Ad` (Ad)  
     - `SoyAd` (Soyad)  
   - **Metot**:  
     - `BaseYazdir()`: Ad ve soyad bilgisini yazdırır.

2. **`Ogrenci`** (Öğrenci)  
   - **Kalıtım Aldığı Sınıf**: `BaseKisi`  
   - **Ek Özellik**:  
     - `OgrenciNo` (Öğrenci Numarası)  
   - **Metot**:  
     - `OgrenciBilgileriYazdir()`: Öğrenci numarası, ad ve soyad bilgilerini yazdırır.

3. **`Ogretmen`** (Öğretmen)  
   - **Kalıtım Aldığı Sınıf**: `BaseKisi`  
   - **Ek Özellik**:  
     - `Maas` (Maaş)  
   - **Metot**:  
     - `OgretmenBilgileriYazdir()`: Maaş bilgisi, ad ve soyad bilgilerini yazdırır.

---

## 🔧 Kod Uygulaması

```csharp
using System;

namespace Patika_Inheritance_Practice
{
    // BaseKisi Sınıfı
    public class BaseKisi
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }

        public void BaseYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {SoyAd}");
        }
    }

    // Ogrenci Sınıfı (BaseKisi'den türetiliyor)
    public class Ogrenci : BaseKisi
    {
        public int OgrenciNo { get; set; }

        public void OgrenciBilgileriYazdir()
        {
            Console.WriteLine($"Öğrenci Numarası: {OgrenciNo}");
            BaseYazdir();  // BaseKisi'deki metot çağrılıyor
        }
    }

    // Ogretmen Sınıfı (BaseKisi'den türetiliyor)
    public class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }

        public void OgretmenBilgileriYazdir()
        {
            Console.WriteLine($"Maaş: {Maas} TL");
            BaseYazdir();  // BaseKisi'deki metot çağrılıyor
        }
    }

    // Ana Program
    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci nesnesi oluşturuluyor
            Ogrenci ogrenci = new Ogrenci
            {
                Ad = "Ali",
                SoyAd = "Yılmaz",
                OgrenciNo = 12345
            };
            ogrenci.OgrenciBilgileriYazdir();

            Console.WriteLine(); // Boşluk bırakmak için

            // Öğretmen nesnesi oluşturuluyor
            Ogretmen ogretmen = new Ogretmen
            {
                Ad = "Ayşe",
                SoyAd = "Demir",
                Maas = 50000
            };
            ogretmen.OgretmenBilgileriYazdir();

            Console.ReadKey(); // Konsolu açık tutar
        }
    }
}
```

---

## ⚙️ Projenin Çalıştırılması

1. Bu projeyi kopyalayın veya kendi ortamınıza klonlayın.
2. **.NET SDK** yüklü olduğundan emin olun.
3. Proje klasöründe bir terminal açın ve şu komutu çalıştırın:
   ```bash
   dotnet run
   ```
4. Program, öğrenci ve öğretmen bilgilerini konsolda gösterecektir.

---

## 📊 Çıktı Örneği

```
Öğrenci Numarası: 12345
Ad: Ali, Soyad: Yılmaz

Maaş: 50000 TL
Ad: Ayşe, Soyad: Demir
```

---

## 🚀 Öğrenilecek Konular

- **Temel sınıf** oluşturarak ortak özellikleri tanımlama.
- Bir **sınıftan kalıtım** alarak yeni işlevler ekleme.
- **Temel sınıfın metodunu türetilmiş sınıfta** kullanma.
- **Kod tekrarını** azaltmak için kalıtım kullanmanın önemi.

---

## 🛠️ Kullanılan Araçlar ve Teknolojiler

- **C#** Programlama Dili  
- **.NET Core SDK**

---

## 📌 Lisans

Bu proje, MIT Lisansı altında lisanslanmıştır. Detaylar için LICENSE dosyasına bakınız.

---

## 🤝 Katkıda Bulunma

Öneri ve geliştirmeler için **issue** açabilir veya **pull request** gönderebilirsiniz.

---

## Yazar

**Serhat Uzun**  
GitHub: [Your GitHub Profile](https://github.com/serhatuzun)  
