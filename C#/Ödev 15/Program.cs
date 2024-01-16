string degisken="Dersimiz CSharp, Hoş Geldiniz!";
string degisken2="CSharp";
// Length
Console.WriteLine(degisken.Length);

// ToUpper , ToLower
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());

// Concat //Verilen String Değişkenine Merhaba Kelimesini Ekler
Console.WriteLine(String.Concat(degisken," Merhaba!"));

// Compare, CompareTo //İki Değişkeni Karşılaştırır Karakter Sayısına Bakarak -1 0 1 Döndürür
// Büyük Küçük Harf Duyarlılığı için True ve False ignoreCase Yazılır
Console.WriteLine(degisken.CompareTo(degisken2)); //-1 , 0 , 1
Console.WriteLine(String.Compare(degisken,degisken2,true)); //-1 , 0 , 1
Console.WriteLine(String.Compare(degisken,degisken2,false)); //-1 , 0 , 1

// Contains //İçinde Geçiyor Mu? Sorusuna Cevap Verir
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("Hoş Geldiniz!"));
Console.WriteLine(degisken.StartsWith("Merhaba!"));

// IndexOf // Verilene Kelime,Harf vb. Index Değerini Verir
Console.WriteLine(degisken.IndexOf("CS"));
Console.WriteLine(degisken.IndexOf("Onur"));
Console.WriteLine(degisken.LastIndexOf("i"));

//Insert //0. indexten başla Merhaba! yaz.
Console.WriteLine(degisken.Insert(0,"Merhaba! "));

// PadLeft , PadRight // 30 Karakter Ekle
Console.WriteLine(degisken+degisken2.PadLeft(30));
Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
Console.WriteLine(degisken.PadRight(50)+degisken2);
Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

// Remove //10 Karakterden Sonrasını Sil //5 Karakterden Sonra 3 Karakter Silme
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5,3));

//Replace // String İfadedeki İfadelerin Yerine Şu Kelime,Harf vb Koy.
Console.WriteLine(degisken.Replace("CSharp","C#"));
Console.WriteLine(degisken.Replace(" ","*"));

// Split // Boşluklara Göre Parçala ve 1. İndeksteki Veriyi Getirir
Console.WriteLine(degisken.Split(' ')[1]);

// Substring // 4. Indeksten Başlayarak 6 Karakter Getir
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4,6));
