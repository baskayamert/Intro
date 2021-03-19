using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class BaseGameSaleManager : IGameSaleService
    {
        public virtual void Sell(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.Name + " bought " + game.Name + " for " + game.Price + "TL");
        }

    }
}
