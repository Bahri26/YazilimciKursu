using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new PlayerValidationManage());
            playerManager.Add(new Player
            {
                Id=1,
                Name="Bahri",
                LastName="KOÇ",
                TcNo="12345678901",
                BirthOfDate=1996
            });

            Console.ReadLine();
        }
    }
}
