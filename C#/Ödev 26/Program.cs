Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Cumartesi);

int sicaklik=24;

if(sicaklik<=(int)HavaDurumu.Normal)
{
    Console.WriteLine("Dışarıya çıkmak için havanın ısınması beklenebilir.");
}
else if(sicaklik >= (int)HavaDurumu.Sicak)
{
    Console.WriteLine("Dışarıya çıkmak için hava sıcak.");
}
else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik <(int)HavaDurumu.CokSicak)
{
    Console.WriteLine("Dışarıya çıkılabilir.");
}

enum Gunler 

{
    Pazartesi=1,
    // Gunlerin numeric değerini 1 den başlat
    Salı,
    Çarşamba,
    Perşembe,
    Cuma=23,
    Cumartesi,
    Pazar
 }

 enum HavaDurumu
 {
    Soguk=5,
    Normal=20,
    Sicak=25,
    CokSicak=30
 }