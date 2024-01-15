// Rekürsif  - Özyineleme
// 3^4 3*3*3*3
int result=1;
for (int i = 1; i < 5; i++)
{
    result*=3;
}
Console.WriteLine(result);
Islemler ex=new();
Console.WriteLine(ex.expo(3,4));

Console.WriteLine(ex.top(1));
Console.WriteLine(ex.fac(5));
// Extension Metotlar
// Extension metotlar ve classlar static olmalıdır.Yoksa erişim olmaz.

string ifade="Onur Yalçın Bağönü";
bool sonuc=ifade.CheckSpaces();
Console.WriteLine(sonuc);
if (sonuc)
    Console.WriteLine(ifade.RemoveWhiteSpaces());
Console.WriteLine(ifade.MakeUperCase());
Console.WriteLine(ifade.MakeLowerCase());

int[] dizi={9,3,6,2,1,5,0};
dizi.SortArray().EkranaYazdir();
dizi.IsEvenNumber();

Console.WriteLine(ifade.GetFirstCharacter());
public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param){
        string[] dizi=param.Split(' ');
        return string.Join("",dizi);
    }

    public static string MakeUperCase(this string param){
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param){
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param){
        Array.Sort(param);
        return param;
    }
    public static void EkranaYazdir(this int[] param)
    {
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }
    }

    public static void IsEvenNumber(this int[] param)
    {
        foreach (var item in param)
        {
            if (item % 2==0)
            Console.WriteLine("Çift");
            else
            Console.WriteLine("Tek");

        }
    }

    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0,1);
    }

} 



public  class Islemler
{

    public int expo(int sayi,int ust)
    {
        if (ust<2)
        {
            return sayi;
        }
        return expo(sayi,ust-1)*sayi;
    }
    //expo(3,4)
    //expo(3,3)*3
    //expo(3,2)*3*3
    //expo(3,1)*3*3*3

    public int fac(int sayi)
    {
        if(sayi<2)
            return sayi;
        return sayi*fac(sayi-1);
    }

    public int top(int say)
    {
        if(say>=10)
            return say;
        return say+top(say+1);
    }
}