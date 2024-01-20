// Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
using System.Collections;

ArrayList asalList=new ArrayList();
ArrayList asalDegilList=new ArrayList();
for (int i = 0; i < 20; i++)
{
    yanlis:
    Console.WriteLine(("{0}.Sayıyı Giriniz"),i+1);
    if(int.TryParse(Console.ReadLine(),out int sayi) && sayi >0)
        if(asalMi(sayi))
        asalList.Add(sayi);
        else
        asalDegilList.Add(sayi);
    else
    {
    Console.WriteLine("Geçersiz Sayı Girişi Tekrar Deneyiniz!");
    goto yanlis;}
}

Console.WriteLine("Asal sayı olanlar.");
asalList.Sort();
float asalOrt=0;
float asalDegilOrt=0;
foreach (int item in asalList)
{
    Console.WriteLine("{0} Sayısı asaldır. ",item);
    asalOrt+=item;
}

Console.WriteLine("Asal sayı olmayanlar.");
asalDegilList.Sort();
foreach (int item in asalDegilList)
{
    Console.WriteLine("{0} Sayısı asal değildir. ",item);
    asalDegilOrt+=item;

    
}
asalDegilOrt+=(float)(asalDegilOrt)/asalDegilList.Count;
asalOrt+=(float)(asalOrt)/asalList.Count;
Console.WriteLine("{0} adet toplam asal sayı vardır. Bu sayıların ortalaması {1}",asalList.Count,asalOrt);
Console.WriteLine("{0} adet toplam asal sayı vardır. Bu sayıların ortalaması {1}",asalDegilList.Count,asalDegilOrt);


bool asalMi(int say)
{
    int kontrol=0;
    for (int i = 2; i < say; i++)
    {
        if(say % i == 0)
        {
            kontrol++;
        }         
    }
    if (kontrol != 0 || say==1 )
    {
        return false;
    }
    else{
        return true;
    }
}
