using System;

namespace app
{
    class Meyve
    {
        public int MeyveId { get; set; }
        public string MeyveAdi { get; set; }
        public int MeyveKiloFiyatı { get; set; }
    }
    static class Manav
    {
        static Meyve[] Meyveler;

        static Manav()
        {
            Meyveler = new Meyve[5];

            Meyveler[0] = new Meyve{MeyveId = 1,MeyveAdi  = "Elma",MeyveKiloFiyatı = 7};
            Meyveler[1] = new Meyve{MeyveId = 2,MeyveAdi  = "Kiraz",MeyveKiloFiyatı = 10};
            Meyveler[2] = new Meyve{MeyveId = 3,MeyveAdi  = "Mandalina",MeyveKiloFiyatı = 3};
            Meyveler[3] = new Meyve{MeyveId = 4,MeyveAdi  = "Kivi",MeyveKiloFiyatı = 14};
            Meyveler[4] = new Meyve{MeyveId = 5,MeyveAdi  = "Şeftali",MeyveKiloFiyatı = 8};
        }
        public static Meyve[] MeyveleriGetir()
        {
            return Meyveler;
        }

        public static Meyve MeyveGetir(int id)
        {
            Meyve meyve = null;

            foreach (var m in Meyveler)
            {
                if (m.MeyveId == id)
                {
                    meyve = m;
                }
            }
            return meyve;

         
        }

        public static int KiloHesapla(int id,int kilo)
        {
           var borc = 0;

           var meyve = MeyveGetir(id);
           
           borc += meyve.MeyveKiloFiyatı*kilo;

           return borc;
            
        }

       
       
    }

    
    class Program
    {

        static void Main(string[] args)
        {
         
          var meyveler = Manav.MeyveleriGetir();

        foreach (var m in meyveler)
        {
          Console.WriteLine($"Meyve Id:{m.MeyveId} , Meyve : {m.MeyveAdi} , Meyve Kg Fiyatı :{m.MeyveKiloFiyatı}");

        }

      

        var sayi = 0;

        for (int i = 0; i < meyveler.Length; i++)
        {
          Console.Write("Meyve Kodunu Seçiniz :");
         
          var secim = int.Parse(Console.ReadLine());

          Manav.MeyveGetir(secim);

        
          Console.Write($"Kaç Kilo {meyveler[i].MeyveAdi} İstersiniz:");

          var kilo = int.Parse(Console.ReadLine());

          var hesap = Manav.KiloHesapla(secim,kilo);

          Console.WriteLine($"Borcunuz : {hesap} TL'dir.");

          Console.WriteLine("***********************************");

          sayi+=hesap;

          Console.WriteLine("Başka bir meyve istermisiniz? - Evet/Hayır");

        

          var meyve = Console.ReadLine();

          if (meyve != "Evet")
          {
              Console.WriteLine($"Toplam Borcunuz :{sayi} TL'dir.");
              Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz...");
             
              break;
          }
        
        
        }
   
          
  
        
         
        






     

        }
              

        
    }
}
