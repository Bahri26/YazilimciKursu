using E_Devlet_Uygulaması.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Devlet_Uygulaması.Abstract
{
    interface ICampaign
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
