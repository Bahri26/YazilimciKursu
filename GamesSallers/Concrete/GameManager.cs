using E_Devlet_Uygulaması.Abstract;
using E_Devlet_Uygulaması.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Devlet_Uygulaması.Concrete
{
    class GameManager
    {
        public void SellGame(Game game,Campaign campaign,Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + game.Price + " " + campaign.Discont);
        }
    }
}
