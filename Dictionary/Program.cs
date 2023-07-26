
namespace dictionary{

    internal class Program
    {
        private static void Main(string[] args)
        {
            // System.Collection.Generic
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10,"arif kemal");
            kullanicilar.Add(12,"kemal ");
            kullanicilar.Add(18, "ahmet");
            kullanicilar.Add(20, "emir");
        
            //Dizinin elemanlarına erişim
            System.Console.WriteLine("***** Elemanlara Erişim *****");
            System.Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item);
            }
 
            // Count
            System.Console.WriteLine(kullanicilar.Count);

            //Contains
            System.Console.WriteLine(kullanicilar.ContainsKey(12));
            System.Console.WriteLine(kullanicilar.ContainsValue("arif kemal"));
 
            //Remove
            System.Console.WriteLine("***** Remove *****");
            kullanicilar.Remove(20);

            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item);
            }

            //Keys
            System.Console.WriteLine("***** Keys *****");

            foreach (var item in kullanicilar.Keys)
            {
                System.Console.WriteLine(item);
            }
            //Values
            System.Console.WriteLine("***** Values *****");

            foreach (var item in kullanicilar.Values)
            {
                System.Console.WriteLine(item);
            }
       
       
        }   
    }
}