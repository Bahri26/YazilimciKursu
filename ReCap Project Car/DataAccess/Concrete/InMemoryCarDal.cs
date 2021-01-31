using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            { 
                new Car {Id=1,BrandId=1,ColorId=2,ModelYear=2002,DailyPrice=100,Description="Fiyatta indirim için aramayınız." },
                new Car {Id=2,BrandId=1,ColorId=2,ModelYear=2010,DailyPrice=200,Description="Fiyatta indirim için aramayınız." },
                new Car {Id=3,BrandId=2,ColorId=2,ModelYear=1999,DailyPrice=80,Description="Fiyat 10-15 Tl indirim yapılabilir." },
                new Car {Id=4,BrandId=2,ColorId=3,ModelYear=1995,DailyPrice=70,Description="Fiyat 10-15 Tl indirim yapılabilir." },
                new Car {Id=5,BrandId=3,ColorId=1,ModelYear=2012,DailyPrice=120,Description="Fiyatta indirim için aramayınız." },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
        }
    }
}
