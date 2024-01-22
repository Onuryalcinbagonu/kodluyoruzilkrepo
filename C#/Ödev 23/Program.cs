Ogrenci ogrenci=new Ogrenci();
ogrenci.Isim="Ayşe";
ogrenci.Soyisim="Yılmaz";
ogrenci.ÖgrenciNo=111;
ogrenci.Sinif=3;
ogrenci.ogrenciBilgileriniGetir();

ogrenci.sinifAtlat();
ogrenci.ogrenciBilgileriniGetir();

Ogrenci ogrenci1=new Ogrenci("Ali","Veli",1,112);
ogrenci1.sinifDusur();
ogrenci1.sinifDusur();
ogrenci1.ogrenciBilgileriniGetir();

class Ogrenci
{
    private string isim ;

    private string soyisim; 
    private int ögrenciNo; 
    private int sinif ;

    // public string Isim { get => isim; set => isim = value; }
    public string Isim { 
        get {return isim;}
        set {isim = value;}
    }

    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int ÖgrenciNo { get => ögrenciNo; set => ögrenciNo = value; }
    public int Sinif 
	{
			get=> sinif;
			set
			{
				if (value < 1)
				{
					Console.WriteLine("Sınıf en az 1 olabilir");
					sinif = 1;
				}
				else { sinif = value; }			
			} 
	}
    public Ogrenci(){}

    public Ogrenci(string isim, string soyisim, int sinif, int ögrenciNo)
    {
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Sinif = sinif;
        this.ÖgrenciNo = ögrenciNo;
    }

    public void ogrenciBilgileriniGetir(){
        Console.WriteLine("***** Öğrenci Bilgileri *****");
        System.Console.WriteLine("Öğrenci Adı  : {0} ",this.isim);
        System.Console.WriteLine("Öğrenci Soyadı  : {0} ",this.soyisim);
        System.Console.WriteLine("Öğrenci No  : {0} ",this.ögrenciNo);
        System.Console.WriteLine("Öğrenci Sınıfı  : {0} ",this.sinif);
    }

    public void sinifAtlat()
    {
        this.Sinif+=1;
    }

    public void sinifDusur()
    {
        this.Sinif-=1;
    }

}