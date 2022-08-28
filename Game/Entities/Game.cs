using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }    
        public string GameType { get; set; }
        public double GamePrice { get; set; }

        public Game(double gamePrice)
        {
            GamePrice = gamePrice;
        }
    }
}
