internal class Program
{
    private static void Main(string[] args)
    {
        // List<T> class
        // System.Collection.Generic
        // T -> object türündedir.

        List<int> sayiListesi = new List<int>();

        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();

        renkListesi.Add("kırmızı");
        renkListesi.Add("mavi");
        renkListesi.Add("turuncu");
        renkListesi.Add("sarı");
        renkListesi.Add("yeşil");

        //Count
        System.Console.WriteLine(renkListesi.Count);
        System.Console.WriteLine(sayiListesi.Count);


        //Foreach ve List.Foreach
        foreach (var sayi in sayiListesi)
        {
            System.Console.WriteLine(sayi);
        }
    
        foreach (var renk in renkListesi)
        {
            System.Console.WriteLine(renk);
        }
    
        sayiListesi.ForEach(sayi=>System.Console.WriteLine(sayi));
        renkListesi.ForEach(renk=>System.Console.WriteLine(renk));
    
  
  
        //Listeden eleman çıkarma
        sayiListesi.Remove(4);
        renkListesi.Remove("sarı");

        sayiListesi.ForEach(sayi=>System.Console.WriteLine(sayi));
        renkListesi.ForEach(renk=>System.Console.WriteLine(renk));
  

        //Index ile çıkarma

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        sayiListesi.ForEach(sayi=>System.Console.WriteLine(sayi));
        renkListesi.ForEach(renk=>System.Console.WriteLine(renk));
 
 
        //Liste içinde arama

        if(sayiListesi.Contains(10))
            System.Console.WriteLine("10 listede bulundu");

        //Elemena ile index'e erişme
        System.Console.WriteLine(renkListesi.BinarySearch("kırmızı"));

        //Diziyi Listeye çevirme
        string[] hayvanlar = {"kedi,köpek"};
        List<string> hayvanListesi = new List<string>(hayvanlar);

        //Listeyi temizleme
        hayvanListesi.Clear();

        //Liste içinde nesne tutmak
        List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

        Kullanıcılar kullanıcı1 = new Kullanıcılar();
        kullanıcı1.Isim ="arif";
        kullanıcı1.Soyisim="erdönmez";
        kullanıcı1.Yas=20;

        
        Kullanıcılar kullanıcı2 = new Kullanıcılar();

        kullanıcı2.Isim ="kemal";
        kullanıcı2.Soyisim="yaran";
        kullanıcı2.Yas=20;
        
        kullanıcıListesi.Add(kullanıcı1);
        kullanıcıListesi.Add(kullanıcı2);
 
        List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

        yeniListe.Add(new Kullanıcılar(){
            Isim="kemal",
            Soyisim="yaran",
            Yas=20
        });
 
    
        foreach (var kullanıcı in kullanıcıListesi)
        {
            System.Console.WriteLine("kullanıcı Adı:"+kullanıcı.Isim);
            System.Console.WriteLine("kullanıcı Soyadı:"+kullanıcı.Soyisim);
            System.Console.WriteLine("kullanıcı Yas:"+kullanıcı.Yas);
        }
    
    
    }
}


public class Kullanıcılar{

    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value;}
    public string Soyisim { get => soyisim; set => soyisim = value;}
    public int Yas { get => yas; set => yas = value;}


}



