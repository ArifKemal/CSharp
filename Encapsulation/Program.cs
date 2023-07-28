internal class Program
{
    private static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "arif";
        ogrenci.Soyisim = "erdönmez";
        ogrenci.No = 20;
        ogrenci.Sinif = 12;
    }
}

class Ogrenci{
    private string isim;
    private string soyisim;
    private int no;
    private int sinif;


    public string Isim{
        get {return isim;}
        set {isim = value;}
    }

    public string Soyisim { get => soyisim; set => soyisim = value;}
    public int No { get => no; set => no = value;}
    public int Sinif { get => sinif; set => sinif = value;}


    public Ogrenci(string isim, string soyisim, int no, int sinif){

        Isim = isim;
        Soyisim = soyisim;
        No = no;
        Sinif = sinif;
    }
    public Ogrenci(){}

    public void OgrenciBilgileriGetir(){
        System.Console.WriteLine("***** Öğrenci Bilgileri *****");
        System.Console.WriteLine("Öğrenci Adi       :{0}",this.Isim);
        System.Console.WriteLine("Öğrenci Soyadi    :{0}",this.Soyisim);
        System.Console.WriteLine("Öğrenci No        :{0}",this.No);
        System.Console.WriteLine("Öğrenci Sinifi    :{0}",this.Sinif);
    }



}