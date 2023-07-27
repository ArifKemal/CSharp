
    
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
        
                Calisan calisan1 = new Calisan();
                calisan1.Ad = "arif";
                calisan1.Soyad = "erdönmez";
                calisan1.No = 20;
                calisan1.Departman = "ar-ge";
        
                calisan1.CalisanBilgileri();
        }

    }

    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public void CalisanBilgileri(){

        

        
            System.Console.WriteLine("çalışanın adı {0}",Ad);
            System.Console.WriteLine("çalışanın soyadı {0}",Soyad);
            System.Console.WriteLine("çalışanın numarası {0}",No);
            System.Console.WriteLine("çalışanın Departmanı {0}",Departman);
        }
    }



