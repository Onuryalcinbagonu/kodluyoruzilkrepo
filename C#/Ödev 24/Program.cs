Console.WriteLine("Çalışan Sayısı: {0} ",Calisan.CalisanSayisi);
//static olarak oluşturulan sınıfa 1 kere girerek çalışmaya başlar. Yani ilksınıf oluşturulurken
Calisan calisan=new Calisan("Ayşe","Yılmaz","İk");
Console.WriteLine("Çalışan Sayısı: {0} ",Calisan.CalisanSayisi);
Calisan calisan1=new Calisan("Ali","Veli","İk");
Calisan calisan2=new Calisan("Serkan","Rıza","İk");
Console.WriteLine("Çalışan Sayısı: {0} ",Calisan.CalisanSayisi);

Console.WriteLine("Toplama işlemi sonucu: {0}",Islemler.Topla(100,200));
Console.WriteLine("Çıkarm işlemi sonucu: {0}",Islemler.Cikar(400,50));
//static sınıflara ad ile çağırılır. Static olan sınıflara üzerinden static sınıflara erişilebilir. 


class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string Isim;
    private string Soyisim;
    private string Departman;

    static Calisan(){
        calisanSayisi=0;
        //Başlangıçta 0 olsun
    }
    public Calisan(string isim, string soyisim, string departman )
    {
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        calisanSayisi++;
    }
}

static class Islemler
{
    public static long Topla (int sayi1, int sayi2)
    {
        return sayi1+sayi2;
    }
    public static long Cikar (int sayi1, int sayi2)
    {
        return sayi1-sayi2;
    }


}