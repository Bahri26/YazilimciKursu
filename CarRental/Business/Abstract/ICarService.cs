using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByBrandId(int id);
        List<Car> GetByDAilyPrice(decimal min, decimal max);
        List<CarDetailsDto> GetCarDetails();
    }
}
