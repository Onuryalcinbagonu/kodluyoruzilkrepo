// // Söz Dizimi
// class SinifAdi
// {
//     [Erişim Belirleyici] [Veri Tipi] ÖzellikAdı
//     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdı([Parametre Listesi])
//     {
//         Metot Komutları
//     }
// }

// Erişim Belirleyiciler
// * Public = Programın her yerinden prop ve metotlara erişilebilir.
// * Private = Programlıdığı sınıf içerisinden prop ve metotlara erişilebilir.
// * Internal = Kendi bulunduğu proje içerisinde  prop ve metotlara erişilebilir.
// * Protected = Bulunduğu ve miras alandığı sınıf içerisinden erişebilir.

Console.WriteLine("****** Çalışan 1 *****");

Calisan calisan1 =new Calisan("Ayşe","Kara",11111111,"İnsan Kaynakları");
calisan1.CalisanBilgileri();

Console.WriteLine("****** Çalışan 2 *****");

Calisan calisan2 =new Calisan();
calisan2.Ad="Deniz";
calisan2.Soyad="Toprak";
calisan2.No=2222222;
calisan2.Departman= "Üretim";
calisan2.CalisanBilgileri();

Console.WriteLine("****** Çalışan 3 *****");

Calisan calisan3 =new Calisan("Ali","Veli");
calisan3.CalisanBilgileri();
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad,string soyad, int no,string departman) // Kurucu Metot
    {
        this.Ad =ad;
        this.Soyad=soyad;
        this.No=no;
        this.Departman=departman;
    }
    public Calisan(string ad,string soyad) // Kurucu Metot
    {
        this.Ad =ad;
        this.Soyad=soyad;

    }

    public Calisan(){} // Kurucu metotlardan overload ederek calisan2 inheritinida kullanabilirim.

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: {0} ",Ad);
        Console.WriteLine("Çalışan Soyadı: {0} ",Soyad);
        Console.WriteLine("Çalışan No: {0} ",No);
        Console.WriteLine("Çalışan Departmanı: {0} ",Departman);
    }
    
}