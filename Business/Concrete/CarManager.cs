using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
            Console.WriteLine(car.Description + " Eklendi");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(car.Description + " Silindi");
        }

        public List<Car> GetAll()
        {
          return _carDal.GetAll();
        }

        public Car GetById(Car car)
        {
           return _carDal.GetById(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(car.Description + " Güncellendi");
        }
    }
}
