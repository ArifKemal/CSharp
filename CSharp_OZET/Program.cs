
// // // // // // // // int a = 5;

// // // // // // // // Console.WriteLine(a);



// // // // // // // bool secim;

// // // // // // // secim = true;
// // // // // // //  Console.WriteLine(secim);


// // // // // // int[] sayilar = {10 ,20 ,30, 40, 50};

// // // // // // string[] isimler = {"arif","kemal"};

// // // // // // Console.WriteLine("1. eleman: {0}",sayilar[0]); 

// // // // // // Console.WriteLine("1. eleman: {0}",isimler[0]); 


// // // // // int not = 55;

// // // // // if (not<0)
// // // // //     Console.WriteLine("deger sifirdan kücük olamaz");

// // // // // else{
// // // // //     Console.WriteLine("Notunuz : {0}",not);

// // // // //     if (not>50)
// // // // //     {
// // // // //         Console.WriteLine("gectiniz");
// // // // //     }

// // // // //     else{
// // // // //         Console.WriteLine("kaldiniz");
// // // // //     }

// // // // // }


// // // // string gun = "salii";

// // // // switch (gun)
// // // // {
// // // //     case "pazartesi":
// // // //         Console.WriteLine("gunlerden pazartesi");
// // // //         break;
// // // //     case "sali":
// // // //         Console.WriteLine("gunlerden sali");
// // // //         break;
// // // //     case "pazar":
// // // //         Console.WriteLine("gunlerden pazar");
// // // //         break;

// // // //     default:
// // // //         Console.WriteLine("yanliş giriş yaptiniz");


// // // // }

// // int[] sayilar = {10 ,20 ,30, 40, 50};


// // // for (int i = 0;i < sayilar.Length; i++){
// // //     Console.WriteLine(sayilar[i]);
// // // }
// // // int i=0;
// // // while(i<sayilar.Length){
// // //     Console.WriteLine(sayilar[i]);
// // //     i++;
// //  // }

// //  foreach (var sayi in sayilar){
// //     Console.WriteLine(sayi);
// //  }

// // class Kisi
// // {
// //     public string ad;
// //     public string soyad;
// //     public string yas;


// //     public void Yaz(){
// //         Console.WriteLine("isim: {0} soyad: {1}", this.ad, this.soyad);
// //     }

// // }

// // internal class Program
// // {
// //     private static void Main(string[] args)
// //     {
// //         Kisi k1 = new Kisi();
// //         k1.ad = "arif";
// //         k1.soyad = "erdönmez";
// //         k1.yas = "20";

// //         Kisi k2 = new Kisi();
// //         k2.ad = "kemal";
// //         k2.soyad = "yaran";
// //         k2.yas = "21";

// //         k1.Yaz();
// //         k2.Yaz();        

// //         // Console.WriteLine("isim: {0} soyad: {1}", k1.ad, k1.soyad);
// //         // Console.WriteLine("isim: {0} soyad: {1}", k2.ad, k2.soyad);
// //     }
// // }









// // static class HelperMethods 
// // {
// //    public static string KarakterDuzelt(string str){
// //     return str
// //         .Replace("ç","c")
// //         .Replace("ö","o")
// //         .Replace("ü","u")
// //         .Replace("ğ","g");
// //    }
// // }
// // class Urun{
// //     public int UrunId { get; set; }
// //     public string UrunAdi { get; set; }
// //     public string Aciklama { get; set; }
// //     public double Fiyat { get; set; }
// //     public bool Satistami { get; set; }

// // }

// // static class Veritabani{
// //     static Urun[] urunler;

// //     static Veritabani()
// //     {
// //         urunler = new Urun[7];

// //         urunler [0] = new Urun() {UrunId = 1, UrunAdi = "redmi10", Aciklama = "iyi", Fiyat = 100, Satistami = true};
// //         urunler [1] = new Urun() {UrunId = 1, UrunAdi = "redmi11", Aciklama = "iyi", Fiyat = 100, Satistami = true};
// //         urunler [2] = new Urun() {UrunId = 1, UrunAdi = "redmi12", Aciklama = "iyi", Fiyat = 100, Satistami = true};
// //         urunler [3] = new Urun() {UrunId = 1, UrunAdi = "redmi13", Aciklama = "iyi", Fiyat = 100, Satistami = true};
// //         urunler [4] = new Urun() {UrunId = 1, UrunAdi = "redmi14", Aciklama = "iyi", Fiyat = 100, Satistami = true};
// //         urunler [5] = new Urun() {UrunId = 1, UrunAdi = "redmi15", Aciklama = "iyi", Fiyat = 100, Satistami = true};
// //         urunler [6] = new Urun() {UrunId = 1, UrunAdi = "redmi16", Aciklama = "iyi", Fiyat = 100, Satistami = true};

// //     }
// //     public static Urun[] UrunleriGetir(){
// //         return urunler; 
// //     }

// // }

// // internal class Program
// // {
// //     private static void Main(string[] args)
// //     {
// //         string str = "ölçme ve değerlendirme";
// //         str =   HelperMethods.KarakterDuzelt(str);
// //         Console.WriteLine(str);

// //         Urun[] urunler = Veritabani.UrunleriGetir();
// //         foreach (var urun in urunler)
// //         {
// //             Console.WriteLine("urun adi: {0} urun fiyati: {1}",urun.UrunAdi,urun.Fiyat);
// //         }
// //     }
// // }






// using System;
// using System.Collections.Generic;

// class Urun
// {
//     public int UrunId { get; set; }
//     public string UrunAdi { get; set; }
//     public string Aciklama { get; set; }
//     public double Fiyat { get; set; }
//     public bool Satistami { get; set; }
// }

// static class Veritabani
// {
//     static Urun[] urunler;

//     static Veritabani()
//     {
//         urunler = new Urun[7];

//         urunler[0] = new Urun() { UrunId = 1, UrunAdi = "redmi10", Aciklama = "iyi", Fiyat = 100 };
//         urunler[1] = new Urun() { UrunId = 2, UrunAdi = "redmi11", Aciklama = "iyi", Fiyat = 100 };
//         urunler[2] = new Urun() { UrunId = 3, UrunAdi = "redmi12", Aciklama = "iyi", Fiyat = 100 };
//         urunler[3] = new Urun() { UrunId = 4, UrunAdi = "redmi13", Aciklama = "iyi", Fiyat = 100 };
//         urunler[4] = new Urun() { UrunId = 5, UrunAdi = "redmi14", Aciklama = "iyi", Fiyat = 100 };
//         urunler[5] = new Urun() { UrunId = 6, UrunAdi = "redmi15", Aciklama = "iyi", Fiyat = 100 };
//         urunler[6] = new Urun() { UrunId = 7, UrunAdi = "redmi16", Aciklama = "iyi", Fiyat = 100 };
//     }
// }

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         string[] isimler = { "arif", "kemal" };

//         List<string> isimListesi = new List<string>();
//         isimListesi.Add("arif");
//         isimListesi.Add("kemal");

//         List<int> sayilar = new List<int>() { 10, 20, 30 };

//         List<Urun> urunler = new List<Urun>()
//         {
//             new Urun(){UrunId = 1, UrunAdi = "redmi16", Aciklama = "iyi", Fiyat = 100, Satistami = true},
//             new Urun(){UrunId = 2, UrunAdi = "redmi16", Aciklama = "iyi", Fiyat = 100, Satistami = true},
//             new Urun(){UrunId = 3, UrunAdi = "redmi16", Aciklama = "iyi", Fiyat = 100, Satistami = true},
//             new Urun(){UrunId = 4, UrunAdi = "redmi16", Aciklama = "iyi", Fiyat = 100, Satistami = true},
//             new Urun(){UrunId = 5, UrunAdi = "redmi16", Aciklama = "iyi", Fiyat = 100, Satistami = true},
//             new Urun(){UrunId = 6, UrunAdi = "redmi16", Aciklama = "iyi", Fiyat = 100, Satistami = true}
//         };
//         urunler.Add(new Urun() { UrunId = 7, UrunAdi = "redmi16", Aciklama = "iyi", Fiyat = 100, Satistami = true });

//         for (int i = 0; i < isimListesi.Count; i++)
//         {
//             Console.WriteLine(isimListesi[i]);
//         }

//         for (int i = 0; i < urunler.Count; i++)
//         {
//             System.Console.WriteLine("urun adi: {0} fiyat: {1}",urunler[i].UrunAdi,urunler[i].Fiyat);
//         }
//         System.Console.WriteLine("-----------------------------------");
//         foreach (var urun in urunler)
//         {
//             System.Console.WriteLine("urun adi: {0} fiyat: {1}",urun.UrunAdi,urun.Fiyat);
//         }

//     }
// }



