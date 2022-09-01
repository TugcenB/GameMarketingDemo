using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamerService gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id=1,
                BirthYear=1996,
                Name="Tugce",
                LastName="B",
                IdentityNumber=12345,
            });
            IGamerService gamer = new OrderManager();
            gamer.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1996,
                Name = "Tugce",
                LastName = "B",
                IdentityNumber = 12345,
            });
        }
    }
}