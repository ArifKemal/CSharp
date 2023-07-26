using System;
internal class Program
{
    private static void Main(string[] args)
    {
        // try
        // {
        //     System.Console.WriteLine("bi sayi giriniz");
        //     int sayi = Convert.ToInt32(Console.ReadLine());
        //     System.Console.WriteLine("girdiğiniz sayi: "+sayi);
        // }
        // catch (Exception ex)
        // {
        //     System.Console.WriteLine("hata" + ex.Message.ToString());

        
        // }         
        // finally{
        //     System.Console.WriteLine("işlem tamamlandi");
        // }

        try
        {
            //int a = int.Parse("test");
            int a = int.Parse("-20000000000");        
        }   
        catch (ArgumentNullException ex)
        {
            System.Console.WriteLine("Boş deger girdiniz: ");
            System.Console.WriteLine(ex);
        }
        catch (FormatException ex) 
        {
            System.Console.WriteLine("veri tipi uygun degil: ");
            System.Console.WriteLine(ex);
        }
        catch(OverflowException ex)
        {
            System.Console.WriteLine("çok küçük ya da çok büyük deger girdiniz: ");
            System.Console.WriteLine(ex);
        
            
        }    

        finally{
            System.Console.WriteLine("islem tamamlandi");
        }
    }

}


        
