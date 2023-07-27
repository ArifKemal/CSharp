﻿
    
    internal class Program
    {
        private static void Main(string[] args)
        {
    //         Söz Dizimi
    //             class SınıfAdı
    //             {
    //                     [Erişim Belirleyici] [veri Tipi] ÖzellikAdi;
    //                     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi]);
    //                 {
    //                     Metot Komutları
    //                 }
    //             }
        
    //             Erişim Berlirleyiciler
    //              * Public
    //              * Private
    //              * Internal
    //              * Protected            
        
                Calisan calisan1 = new Calisan("arif","erdönmez",20,"ar-ge");
                
        }

    }

    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public Calisan(string ad, string soyad, int no, string departman){
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }


        public Calisan(){}



        public void CalisanBilgileri(){

        

        
            System.Console.WriteLine("çalışanın adı {0}",Ad);
            System.Console.WriteLine("çalışanın soyadı {0}",Soyad);
            System.Console.WriteLine("çalışanın numarası {0}",No);
            System.Console.WriteLine("çalışanın Departmanı {0}",Departman);
        }
    }