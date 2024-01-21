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


Calisan calisan1 =new Calisan();
calisan1.Ad="Ayşe";
calisan1.Soyad="Kara";
calisan1.No=11111111;
calisan1.Departman= "İnsan Kaynakları";
 
calisan1.CalisanBilgileri();

Console.WriteLine("****** *****");

Calisan calisan2 =new Calisan();
calisan2.Ad="Deniz";
calisan2.Soyad="Toprak";
calisan2.No=2222222;
calisan2.Departman= "Üretim";

calisan2.CalisanBilgileri();
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: {0} ",Ad);
        Console.WriteLine("Çalışan Soyadı: {0} ",Soyad);
        Console.WriteLine("Çalışan No: {0} ",No);
        Console.WriteLine("Çalışan Departmanı: {0} ",Departman);
    }
    
}