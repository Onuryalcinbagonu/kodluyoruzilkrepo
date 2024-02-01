Dikdortgen dikdortgen=new Dikdortgen();
dikdortgen.kisaKenar=5;
dikdortgen.uzunKenar=6;
Console.WriteLine("Class ile dikdörtgen hesabı :{0} ", dikdortgen.alanHesapla());
//classlar null, 0 gibi verileri otomatik olarak oluşturur.kisakenara değer atanmazsa 0 atar.
// DikdortgenStruct dikdortgenStruct=new DikdortgenStruct();
DikdortgenStruct dikdortgenStruct;
dikdortgenStruct.kisaKenar=5;
dikdortgenStruct.uzunKenar=6;
Console.WriteLine("Struct ile dikdörtgen hesabı :{0} ", dikdortgenStruct.alanHesapla());


class Dikdortgen
{
    public int kisaKenar;
    public int uzunKenar;
    public Dikdortgen()
    {
        kisaKenar=5;
        uzunKenar=6;
    }
    public long alanHesapla()
    {
        return this.kisaKenar*this.uzunKenar;
    }

}

struct DikdortgenStruct
{
    public int kisaKenar;
    public int uzunKenar;
    public DikdortgenStruct(int k,int u)
    {
        kisaKenar=k;
        uzunKenar=u;
    }
    public long alanHesapla()
    {
        return this.kisaKenar*this.uzunKenar;
    }
    
}