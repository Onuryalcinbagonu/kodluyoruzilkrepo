// 1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
try
{
    
Console.Write("Kaç Adet Sayı Girişi Yapmak İstiyorsnuz: ");
int sayi= Convert.ToInt32(Console.ReadLine());
int[] dizi=new int[sayi];

    for (int i = 0; i < sayi; i++)
    {
        Console.WriteLine("Bir Sayı Giriniz");
        dizi[i]=Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < dizi.Length; i++)
    {
        if (dizi[i] % 2 ==0)
        {
            System.Console.WriteLine(dizi[i]+" sayısı çiftir.");
        }
    }
    }

catch (ArgumentNullException ex)
{
    Console.WriteLine("Yanlış veri tipi girdiniz"+ ex);
}
finally
{
    Console.WriteLine("İşlem tamamlandı");
}

// 2. Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
try
{
    
Console.Write("İki adet pozitif sayı giriniz. n,m : ");
string[] say= Console.ReadLine().Split(',');

int gr= int.Parse(say[0]);
int[] dz=new int[gr];

    for (int i = 0; i < gr; i++)
    {
        Console.WriteLine("Bir Sayı Giriniz");
        dz[i]=Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < dz.Length; i++)
    {
        if (dz[i] == int.Parse(say[1]) || dz[i] % int.Parse(say[1]) == 0)
        {
            System.Console.WriteLine(dz[i]+" sayısı m ye eşit ya da tam bölünüyor");
        }
    }
    
}
catch (Exception ex)
{
    
    System.Console.WriteLine("Hata :"+ex.Message);
}

// 3. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

try
{
    
Console.Write("Kaç Adet Kelime Girişi Yapmak İstiyorsnuz: ");
int ds= int.Parse(Console.ReadLine());
string[] kelDizi=new string[ds];

    for (int i = 0; i < ds; i++)
    {
        Console.WriteLine("Bir Kelime Giriniz");
        kelDizi[i]=Console.ReadLine();
    }

    for (int i = ds; i > 0; i--)
    {
        Console.WriteLine(kelDizi[i-1]);
    }
    
}
catch (Exception ex)
{
    
    Console.WriteLine("Hata :"+ex.Message);
}

// 4. Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

try
{
   
Console.WriteLine("Bir cümle giriniz");
string[] kelime=Console.ReadLine().Split(' ');
int kelSay=kelime.Count();
int harfSay=0;
foreach (string item in kelime)
{
    harfSay=harfSay+item.Count();
}
Console.WriteLine(kelSay);
Console.WriteLine(harfSay); 
}
catch (Exception ex)
{
    Console.WriteLine("Hata :"+ex.Message);
}