// System.Collections.Generic

Dictionary<int,string> kullanicilar=new Dictionary<int, string>();
kullanicilar.Add(10,"Ayşe Yılmaz");
kullanicilar.Add(12,"Ahmet Yılmaz");
kullanicilar.Add(18,"Deniz Toprak");
kullanicilar.Add(20,"Özcan Lale");

// Dizinin elemanlarına erişim
Console.WriteLine("***** Elemanlara Erişim *****");
Console.WriteLine(kullanicilar[12]);
foreach (var item in kullanicilar)
{
    Console.WriteLine(item);
}

// Count
Console.WriteLine("***** Count *****");

System.Console.WriteLine(kullanicilar.Count);

// Contains
Console.WriteLine("***** Contains *****");

Console.WriteLine(kullanicilar.ContainsKey(12));
Console.WriteLine(kullanicilar.ContainsValue("Ali Veli"));

// Remove
Console.WriteLine("***** Remove *****");
kullanicilar.Remove(12);

foreach (var item in kullanicilar)
{
    Console.WriteLine(item.Value);
}

// Keys
Console.WriteLine("***** Keys *****");
foreach (var item in kullanicilar.Keys)
{
    Console.WriteLine(item);
}

// Values
Console.WriteLine("***** Values *****");
kullanicilar.Remove(12);
foreach (var item in kullanicilar.Values)
{
    Console.WriteLine(item);
}
