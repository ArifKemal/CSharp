internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("bir sayi giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        for (int i = 1; i <= sayi; i++)
        {
            if(i%2==1)
                System.Console.WriteLine(i);            
        }

    }
}