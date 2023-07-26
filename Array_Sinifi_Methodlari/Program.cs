internal class Program
{
    private static void Main(string[] args)
    {
        //sort
        int[] sayiDizi = {23,12,4,86,72,3,11,17};

        System.Console.WriteLine("*****Sirasiz liste*****");
        foreach (var sayi in sayiDizi)
        {
            System.Console.WriteLine(sayi);
        }

        System.Console.WriteLine("*****Sirali liste*****");
        Array.Sort(sayiDizi);
        foreach (var sayi in sayiDizi)
        {
            System.Console.WriteLine(sayi);
       }

        //clear
        // 2. indexten başlayarak 2 eleman sildi
        System.Console.WriteLine("***** Array Clear *****");
        Array.Clear(sayiDizi,2,2);


        foreach (var sayi in sayiDizi)
        {
            System.Console.WriteLine(sayi);
        }

        //reverse
        System.Console.WriteLine("***** Array Reverse *****");
        Array.Reverse(sayiDizi);

        foreach (var sayi in sayiDizi)
        {
            System.Console.WriteLine(sayi);
        }

        //IndexOf

        System.Console.WriteLine("***** Array IndexOf");
        System.Console.WriteLine(Array.IndexOf(sayiDizi,4));
 
        //Resize
        System.Console.WriteLine("***** Array Resize*****");
        Array.Resize<int>(ref sayiDizi,9);
        sayiDizi[8]=99;
        foreach (var sayi in sayiDizi)
        {
            System.Console.WriteLine(sayi);
        }
 
    }
}