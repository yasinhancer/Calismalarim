using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformProject.Entities;

namespace GamePlatformProject.Abstract
{
    interface IGameSaleService
    {
        void Sale(Gamer gamer, Game game, Campaign campaign);
    }
}
