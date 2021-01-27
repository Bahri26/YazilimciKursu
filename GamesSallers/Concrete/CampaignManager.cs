using E_Devlet_Uygulaması.Abstract;
using E_Devlet_Uygulaması.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Devlet_Uygulaması.Concrete
{
    public class CampaignManager : ICampaign
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} kampanya eklendi", campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} kampanya silindi", campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} kampanya güncellendi", campaign.Name);
        }
    }
}
