internal class Program
{
    private static void Main(string[] args)
    {
        // 3^4
        int result=1;
        for (int i = 1; i <5 ; i++)
        
            result = result*3;
        System.Console.WriteLine(result);
    
        Islemler instance=new();
        System.Console.WriteLine(instance.Expo(3,4));

        string ifade = "Arif Kemal Erdönmez";
        bool sonuc=ifade.CheckSpaces();
        System.Console.WriteLine(sonuc);
        if (sonuc)
        {
            System.Console.WriteLine(ifade.RemoveWhiteSpaces());
        }
    
    }

}

public class Islemler{

    public int Expo(int sayi, int üs){
        if(üs<2)
            return sayi;
        return Expo(sayi,üs-1)*sayi;
    }
}

public static class Extension{
    public static bool CheckSpaces(this string param){
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param){
        string[] dizi= param.Split(" ");
        return string.Join("",dizi);
    }








}    

