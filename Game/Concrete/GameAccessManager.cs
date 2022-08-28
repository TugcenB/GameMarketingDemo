using GameCampaign.Abstract;
using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Concrete
{
    public class GameAccessManager : IGamerSystemService
    {
        private IGamerCheckService _gamerCheckService;

        public GameAccessManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.Name+" have an access to the games.");
            }
            else
            {
                Console.WriteLine(gamer.Name+" is not real person.");
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine(gamer.Name+" removed.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name+" updates the status.");
        }
    }
}
