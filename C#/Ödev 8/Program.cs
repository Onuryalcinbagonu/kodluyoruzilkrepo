// While
// 1 başlayarak consoledan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp console yazdıran program
// Console.Write("Lütfen bir sayı giriniz: ");
// int sayi = int.Parse(Console.ReadLine());
// int sayac = 1;
// int toplam=0;
// while (sayac<=sayi)
// {

//     toplam+=sayac;
//     sayac++;
// }
// Console.WriteLine(toplam/sayi);

// 'a' dan 'z' ye kadar tüm harfleri console yazdıralım.
// char character='a';
// while (character< 'z')
// {
//     Console.Write(character);
//     character++;
// }

Console.Write("***** Foreach *****");
string[] arabalar = {"BMW","Ford","Toyota","Nissan"};
foreach (string araba in arabalar)
{
    Console.WriteLine(araba);
}
