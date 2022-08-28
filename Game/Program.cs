using GameCampaign.Abstract;
using GameCampaign.Concrete;
using GameCampaign.Entities;
using System;

namespace GameCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Name = "Talha";
            gamer.BirthDate = new DateTime(2013,12,23);
            gamer.NationalId = "12345678910";

            IGamerSystemService gamerSystemService = new GameAccessManager(new GamerCheckManager());
            gamerSystemService.Add(gamer);

            IGameSellingService gameSell = new GameManager();
            gameSell.AddCampaign(gamer,new Game(100));
            

        }
    }
}