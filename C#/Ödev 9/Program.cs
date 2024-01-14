// Dizi Tanımla
string[] renkler = new string[5];

string[] hayvanlar={"Kedi","Köpek","Kuş","Maymun"};

int[] dizi;
dizi=new int[5];

// Dizilere Değer Atama ve Erişim
renkler [0]="Mavi";
dizi[3]=10;

Console.WriteLine(hayvanlar[1]);
System.Console.WriteLine(dizi[3]);
System.Console.WriteLine(renkler[0]);

// Döngülerle Dizi Kullanımı
// Klavyeden girilen n tane sayının ortalamasını hesaplayan program

Console.Write("Lütfen Dizinin Eleman Sayısını giriniz:");
int diziUzunlugu=int.Parse(Console.ReadLine());
int[] sayiDizisi=new int[diziUzunlugu];

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz: ",i+1);
    dizi[i]=int.Parse(Console.ReadLine());
}

int toplam=0;
foreach (var sayi in dizi)
    toplam+=sayi;

Console.WriteLine("Ortalama :"+(float)(toplam)/diziUzunlugu);
