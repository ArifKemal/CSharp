using System;
using System.Collections;

namespace arraylist
{
    
    internal class Program
    {
        private static void Main(string[] args)
        {
            //System.Collection namespace

            ArrayList liste = new ArrayList();
            // liste.Add("arif");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            // //içerisindeki verilere erişme
            // System.Console.WriteLine(liste[1]);

            // foreach (var item in liste)
            // {
            //     System.Console.WriteLine(item);
            // }
      
            // AddRange
            System.Console.WriteLine("***** Add Range *****");
            string[] renkler = {"kırmzı","sarı","yesil"};
            List<int> sayilar = new List<int>(){1,2,3,4,5,6};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }
      
            //Binary Search
            System.Console.WriteLine("***** Binary Search *****");
            System.Console.WriteLine(liste.BinarySearch(6));
      
        }
    }
}