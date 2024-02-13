public class Canlilar
// public sealed class Canlilar
// Kalıtımı engellemek için sealed anahtar kelimesi kullanılır
{
    protected void Beslenme()
    {
        Console.WriteLine("Canlılar beslenir.");
    }
    protected void Solunum()
    {
        Console.WriteLine("Canlılar solunum yapar.");
    }
    protected void Bosaltim()
    {
        Console.WriteLine("Canlılar boşaltım yapar.");
    }

    public virtual void UyaranlaraTepki(){
        Console.WriteLine("Canlılar uyaranlara tepki verir");
    }

}