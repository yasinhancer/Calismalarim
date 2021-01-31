using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatformProject
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
    }
}
