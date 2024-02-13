public class Bitkiler:Canlilar
{
    protected void Fotosentez()
    {
        Console.WriteLine("Bitkiler fotosentez yapar");
    }

    public override void UyaranlaraTepki()
    {
        // base.UyaranlaraTepki();
        Console.WriteLine("Bitkiler güneşe tepki verir.");
    }
}
    public class TohumluBitkiler:Bitkiler{
    public TohumluBitkiler(){
        base.Fotosentez();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
        //Miras verilen metotlara ulaşmaya sağlanır. (protected)
        base.UyaranlaraTepki();
    }
    public void TohumlaCogalma(){
        Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
    }
}
public class TohumsuzBitkiler:Bitkiler{
    public TohumsuzBitkiler(){
        base.Fotosentez();
    }
    public void SporlaCogalma(){
        Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
    }
}

