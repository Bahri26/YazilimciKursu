﻿using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} Araba günlük fiyatı = {1}", car.BrandName, car.DailyPrice);
            }

            Console.ReadLine();
        }
    }
}
