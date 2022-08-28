using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Abstract
{

    public interface IGamerSystemService
    {
        //Oyuncuların sisteme kayıt olabilmesi için...
        void Add(Gamer gamer);
        void Remove(Gamer gamer);
        void Update(Gamer gamer);
    }
}