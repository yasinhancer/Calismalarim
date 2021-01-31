using System;
using GamePlatformProject.Concrete;
using GamePlatformProject.Entities;

namespace GamePlatformProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            CampaignManager campaignManager = new CampaignManager();
            GameSaleManager gameSaleManager = new GameSaleManager();
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                BirthYear = 2002,
                FirstName = "YASİN",
                LastName = "HANÇER",
                NationalityId = 123456
            };
            gamerManager.Add(gamer1);
            
            Game ets2 = new Game()
            {
                Id = 1,
                Name = "Euro Truck Simulator 2",
                Price = 40,
                ReleaseYear = "2012"
            };
            //gameManager.Add(ets2);
            Game gtaV = new Game()
            {
                Id = 2,
                Name = "Grand Theft Auto V",
                Price = 180,
                ReleaseYear = "2013"
            };
            //gameManager.Add(gtaV);
            Game pubg = new Game()
            {
                Id = 3,
                Name = "PlayerUnknown's Battlegrounds",
                Price = 80,
                ReleaseYear = "2017"
            };
            //gameManager.Add(pubg);

            Campaign ogrenciIndirimiKampanyasi = new Campaign()
            {
                Name = "Öğrenci İndirimi Kampanyası",
                Description = "Öğrenciler için tüm oyunlar %25 indirimli, eğer sende öğrenciysen bu fırsatı kaçırma!",
                DiscountRate = 25
            };
            //campaignManager.Add(ogrenciIndirimiKampanyasi);
            Campaign oyunGecesiKampanyasi = new Campaign()
            {
                Name = "Oyun Gecesi Kampanyası",
                Description = "Oyun gecesine özel tüm oyunlarda geçerli %20 indirimi kaçırma!",
                DiscountRate = 20
            };
            //campaignManager.Add(oyunGecesiKampanyasi);
            Campaign kisKampanyasi = new Campaign()
            {
                Name = "Kış Kampanyası",
                Description =
                    "Evde olduğumuz bu soğuk kış günlerinde, sımsıcak indirimler seninle! Tüm oyunlarda geçerli %40 indirimi kaçırma!",
                DiscountRate = 40
            };
            //campaignManager.Add(kisKampanyasi);
            
            //KAMPANYASIZ OYUN SATIŞI
            gameSaleManager.Sale(gamer1, ets2);
            
            //KAMPANYALI OYUN SATIŞI
            gameSaleManager.Sale(gamer1,gtaV,oyunGecesiKampanyasi);
            Console.ReadLine();
        }
    }
}
