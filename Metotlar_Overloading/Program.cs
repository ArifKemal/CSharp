internal class Program
{
    private static void Main(string[] args)
    {
        string sayi ="999"; 
        int outSayi;

        bool sonuc = int.TryParse(sayi, out outSayi);
            if(sonuc){
                System.Console.WriteLine("başarili");
                System.Console.WriteLine(outSayi);
            }
            else{
                System.Console.WriteLine("başarisiz");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplamSonucu);
            System.Console.WriteLine(toplamSonucu);

    
            int ifade=999;
            instance.EkranaYazdir((Convert.ToString(ifade)));
            System.Console.WriteLine(ifade);
    
    }
}

class Metotlar{

    public void Topla(int a, int b, out int toplam){
        toplam = a+b;
    }

    public void EkranaYazdir(string veri){
        System.Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri){
        System.Console.WriteLine(veri);
    }










}


