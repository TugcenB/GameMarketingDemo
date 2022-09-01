using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public abstract class CampaignManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Kampanya oluşturuldu");
        }

        public virtual void Remove(Gamer gamer)
        {
            Console.WriteLine("Kampanya kaldırıldı");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
