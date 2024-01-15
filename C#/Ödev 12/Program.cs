//out parametreler
string sayi="999";

bool sonuc=int.TryParse(sayi,out int outSayi);
//int değişkenine dönüşebilir mi sorusuna TryParse tarafından cevap döner. out ile o sayiya dönüşürse outSayi değişkene atama yapar. Eğer cevap false ise outSayi 0 değerini alır.

if(sonuc)
{
    System.Console.WriteLine("Başarılı");
    System.Console.WriteLine(outSayi);
}
else
{
    System.Console.WriteLine("Başarısız");
    System.Console.WriteLine(outSayi);

}

Metotlar instance=new Metotlar();
instance.topla(4,5,out int toplamSonucu);
Console.WriteLine(toplamSonucu);

//Metot Aşırı Yükleme - Overloading
int ifade=999;
instance.ekranaYazdir(ifade);
instance.ekranaYazdir("Onur","Yalcin");


class Metotlar
{

    public void topla(int a, int b,out int toplam)
    {
        toplam=a+b;
    }
    public void ekranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public void ekranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }

    public void ekranaYazdir(string veri,string veri2)
    {
        Console.WriteLine(veri+veri2);
    }
}