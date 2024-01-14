// Sort
int[] sayiDizi={23,12,4,86,72,3,11,17};

Console.WriteLine("***** Sırasız Dizi *****");
diziDongu(sayiDizi);

Console.WriteLine("***** Sıralı Dizi *****");
Array.Sort(sayiDizi);

diziDongu(sayiDizi);

//Clear
Console.WriteLine("***** Array Clear *****");
Array.Clear(sayiDizi,2,2);
// sayiDizi elemanlarını kullanarak 2 indexten itibaren 2 tane elemanı sıfırlar
diziDongu(sayiDizi);

// Reverse
Console.WriteLine("***** Array Reverse *****");
Array.Reverse(sayiDizi);
diziDongu(sayiDizi);

// IndexOf
Console.WriteLine("***** Array IndexOf *****");
Console.WriteLine(Array.IndexOf(sayiDizi,23));
// 23 sayısı dizide hangi indexte

// Resize
Console.WriteLine("***** Array Resize *****");
Array.Resize<int>(ref sayiDizi,9);
// Dizinin boyutunu 9 yapar
sayiDizi[8]=99;
diziDongu(sayiDizi);

void diziDongu(Array sayiDizi)
{
    foreach (var sayi in sayiDizi)
    Console.WriteLine(sayi);
}
