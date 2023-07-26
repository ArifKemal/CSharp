internal class Program
{
    private static void Main(string[] args)
    {
        int a=1;
        int b=3;

        System.Console.WriteLine(a+b);

        int sonuc=Topla(a,b);
        System.Console.WriteLine(sonuc);
    
        Metotlar örnek = new Metotlar();
        örnek.EkranaYazdir(Convert.ToString(sonuc));


        int sonuc2 = örnek.ArttirVeTopla(a,b);
        örnek.EkranaYazdir(Convert.ToString(sonuc2));
    }
    static int Topla(int deger1, int deger2){
        return(deger1 + deger2);
    }
}

class Metotlar{
    public void EkranaYazdir(string veri){
        System.Console.WriteLine(veri);
    }
    public int ArttirVeTopla(int deger1,int deger2){
        deger1+=1;
        deger2+=1;
        return deger1+deger2;
    }

}

