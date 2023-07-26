internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        if(time >= 6 && time<11){

            System.Console.WriteLine("günaydin");
        } 
        else if (time <= 18){
            System.Console.WriteLine("iyi günler");
        }
        else{
            System.Console.WriteLine("iyi geceler");
        }

        string sonuc = time <= 18 ? "iyi günler" : "iyi geceler";

        System.Console.WriteLine(sonuc);
    }

}
    

        