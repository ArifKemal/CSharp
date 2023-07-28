internal class Program
{
    private static void Main(string[] args)
    {
        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.KisaKenar = 3;
        dikdortgen.UzunKenar = 4;

        System.Console.WriteLine("class alan hesabı {0}",dikdortgen.AlanHesapla()); 
    }
}

class Dikdortgen{

    public int KisaKenar;
    public int UzunKenar;
    public long AlanHesapla(){
        return this.KisaKenar * this.UzunKenar;
    }
}


struct Dikdortgen_Struct
{
    public int KisaKenar;
    public int UzunKenar;
    public long AlanHesapla(){
        return this.KisaKenar * this.UzunKenar;
    }
}
