using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class OrderManager : CampaignManager
    {
        public override void Add(Gamer gamer)
        {
            Console.WriteLine("Oyun kampanyalı olarak listeye eklendi.");
        }

        public override void Remove(Gamer gamer)
        {
            base.Remove(gamer);
        }

        public override void Update(Gamer gamer)
        {
            base.Update(gamer);
        }
    }
}
