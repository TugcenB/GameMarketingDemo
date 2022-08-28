using GameCampaign.Abstract;
using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Concrete
{
    public class GameManager : IGameSellingService
    {
        public void GameSell(Gamer gamer, Game game)
        {
            
            Console.WriteLine(gamer.Name+" get the game for "+game.GamePrice);
        }
        public void AddCampaign(Gamer gamer, Game game)
        {
            Console.WriteLine("Game has discount.New price is "+game.GamePrice*0.9);
        }

        public void RemoveCampaign(Gamer gamer, Game game)
        {
            Console.WriteLine("Game discount has been removed.");
        }

        public void UpdateCampaign(Gamer gamer, Game game)
        {
            Console.WriteLine("Campaign has been updated.");
        }
    }
}
