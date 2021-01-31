using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformProject.Abstract;
using GamePlatformProject.Entities;

namespace GamePlatformProject.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign=null)
        {
            if (campaign != null)
            {
                Console.WriteLine(gamer.FirstName + " adlı oyuncu, " + game.Name + " adlı oyunu " + campaign.Name + "'ndan yararlanarak " + CalculatePrice(game,campaign) + "TL karşılığında kütüphanesine ekledi.");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " adlı oyuncu, " + game.Name + " adlı oyunu kampanyasız olarak " + game.Price + "TL karşılığında kütüphanesine ekledi.");
            }
        }
       
        public int CalculatePrice(Game game, Campaign campaign)
        {
            return (int) (game.Price - (game.Price * campaign.DiscountRate/100));
        }
    }
}
