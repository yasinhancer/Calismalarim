using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatformProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun sisteme eklendi!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun sistemden silindi.");
        }
    }
}
