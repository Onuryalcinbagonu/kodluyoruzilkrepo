//List<>
//System.Collections.Generic
// T-> object türündedir.

using System.Net.Sockets;

List<int> sayiListesi =new List<int>();

sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);

List<string> renklistesi=new List<string>();
renklistesi.Add("Kırmızı");
renklistesi.Add("Mavi");
renklistesi.Add("Turuncu");
renklistesi.Add("Sarı");
renklistesi.Add("Yeşil");

//Count
Console.WriteLine(renklistesi.Count);
Console.WriteLine(sayiListesi.Count);

// foreach ve List.ForEach ile elemanlara erişmek
foreach(var sayi in sayiListesi)
    Console.WriteLine(sayi);
foreach(var renk in renklistesi)
    Console.WriteLine(renk);

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renklistesi.ForEach(renk=> Console.WriteLine(renk));

// Listeden eleman çıkarma
sayiListesi.Remove(4);
renklistesi.Remove("Yeşil");

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renklistesi.ForEach(renk=> Console.WriteLine(renk));

sayiListesi.RemoveAt(0);
renklistesi.RemoveAt(1);

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renklistesi.ForEach(renk=> Console.WriteLine(renk));

// TcpListener içerisinde Arama
if(sayiListesi.Contains(10))
{
    Console.WriteLine("10 Liste İçerisinde Bulundu");
}

// Eleman ile index e erişme
Console.WriteLine(renklistesi.BinarySearch("Turuncu"));

// Diziyi listeye çevirme
string[] hayvanlar ={"Kedi","Köpek","Kuş"};
List<string> hayvanListesi = new List<string>(hayvanlar);

//Listeyi nasıl temizleriz?

hayvanListesi.Clear();

// Liste içerisinde nesne tutmak
List<Kullanicilar> kullaniciListesi =new List<Kullanicilar>();

Kullanicilar kullanici1 = new Kullanicilar();
kullanici1.Isim="Ayşe";
kullanici1.Soyisim="Yılmaz";
kullanici1.Yas=26;

Kullanicilar kullanici2 = new Kullanicilar();
kullanici2.Isim="Ömer";
kullanici2.Soyisim="Çalışkan";
kullanici2.Yas=26;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);

List<Kullanicilar> yeniListe= new List<Kullanicilar>();
yeniListe.Add(new Kullanicilar(){
    Isim="Deniz",
    Soyisim="Toprak",
    Yas=24

});

foreach (Kullanicilar kullanici in kullaniciListesi)
{
    System.Console.WriteLine("Kullanıcı Adı: "+kullanici.Isim);
    System.Console.WriteLine("Kullanıcı Soyadı: "+kullanici.Soyisim);
    System.Console.WriteLine("Kullanıcı Yaşı:"+kullanici.Yas);
}

yeniListe.Clear();
public class Kullanicilar{
    private string isim;
    private string soyisim;

    private int yas;

    public string Isim{get=>isim;set =>isim=value;}
    public string Soyisim{get=>soyisim;set =>soyisim=value;}

    public int Yas{get=>yas;set=>yas=value;}
}