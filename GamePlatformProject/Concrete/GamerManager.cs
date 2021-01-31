using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatformProject
{
    //NOT: BİR MANAGER SINIFININ İÇERİSİNDE, BAŞKA BİR MANAGER SINIFINI KULLANACAKSAN, ONU NEWLEME! AŞAĞIDAKİ GİBİ YAP
    class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName + " adlı oyuncu doğrulandı ve sisteme eklendi!");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, oyuncu eklenemedi.");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu sistemde güncellendi.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu sistemden silindi.");
        }
    }
}
