internal class Program
{
    private static void Main(string[] args)
    {
        int month = DateTime.Now.Month;

        switch (month)
        {
            case 1:
                System.Console.WriteLine("Nisan ayindasiniz");
                break;
            case 7:
                System.Console.WriteLine("Temmuz ayindasiniz");
                break;
            default:
                System.Console.WriteLine("hatali giris yaptiniz");
            break;
        }   
    }
}


