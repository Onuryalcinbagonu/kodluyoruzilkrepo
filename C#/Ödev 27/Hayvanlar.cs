public class Hayvanlar:Canlilar
{
    protected void Adaptasyon()
    {
        Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
    }

    public override void UyaranlaraTepki()
    {
        // Virtual ile işaretlenmiş metodu getirilir çalıştırılır.
        base.UyaranlaraTepki();
        // Üst sınıftaki komutları çalıştırır.
        Console.WriteLine("Hayvanlar temasa tepki verir.");
    }

}

public class Surungenler:Hayvanlar{
    public Surungenler()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }
    public void SurunerekHareketEderler(){
        Console.WriteLine("Sürüngenler sürünürerek hareket eder.");
    }
}

public class Kuslar:Hayvanlar{
    public Kuslar(){
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
        base.UyaranlaraTepki();
    }
    public void Ucar()
    {
        Console.WriteLine("Uçabilen kuşlar vardır.");
    }

}