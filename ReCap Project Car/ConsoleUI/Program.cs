using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} Araba günlük fiyatı = {1}", car.BrandId, car.DailyPrice);
            }

            Console.ReadLine();
        }
    }
}
