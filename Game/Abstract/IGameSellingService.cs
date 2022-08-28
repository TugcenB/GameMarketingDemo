using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Abstract
{
    public interface IGameSellingService
    {
        void GameSell(Gamer gamer,Game game);//yapılan satış oyuncuyla ilişkilendirildi.
        void AddCampaign(Gamer gamer, Game game);
        void RemoveCampaign(Gamer gamer, Game game);
        void UpdateCampaign(Gamer gamer, Game game);
    }
}
