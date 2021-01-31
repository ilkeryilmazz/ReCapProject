using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        Car GetById(Car car);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
