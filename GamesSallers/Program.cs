using E_Devlet_Uygulaması.Concrete;
using E_Devlet_Uygulaması.Entity;
using System;

namespace GameSales
{
    class Program
    {
        Customer customer1 = new Customer
        {
            Id = 1,
            FirstName = "Ahmet",
            LastName = "Sarı",
            TcNo = "1234567891",
            DateOfBirth = new DateTime(1998,2,4)
        };

        Customer customer2 = new Customer
        {
            Id = 2,
            FirstName = "Mehmet",
            LastName = "Yeşil",
            TcNo = "1334567890",
            DateOfBirth = new DateTime(1995, 3, 4)
        };

        CustomerManager customerManager = new CustomerManager(new CheckCustomerManager());
        Game game = new Game() { Id = 1, Name = "FIFA20", Price = 300 };

        CampaignManager campaignManager = new CampaignManager();
        GameManager gameManager = new GameManager();

        gameManager.SaleGame(game,campaign,customer);
        
    }
}
