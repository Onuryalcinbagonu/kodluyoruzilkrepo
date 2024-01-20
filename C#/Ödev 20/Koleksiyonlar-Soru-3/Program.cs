//  Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;


string gelen=Console.ReadLine();
char[] cumleSesl=gelen.ToCharArray();
char[] sesli={ 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
string sakla=string.Empty;
foreach (char item in cumleSesl)
{
   foreach (char s in sesli)
   {
     if(item==s){
         sakla+=item;
     }
   }
}

char[] gel=new char[sakla.Length];
for (int i = 0; i < sakla.Length; i++)
{
    gel[i]=sakla[i];
}
Array.Sort(gel);
foreach (char item in gel)
{
    Console.WriteLine(item);
}