using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.InMemory
{
    
  public  class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car
                {
                    Id=1,BrandId=1,ColorId=1,DailyPrice=1000,Description="2018 Model Araba",ModelYear=2018
                },
                 new Car
                {
                    Id=2,BrandId=2,ColorId=2,DailyPrice=1200,Description="2020 Model Araba",ModelYear=2020
                },
                  new Car
                {
                    Id=3,BrandId=3,ColorId=3,DailyPrice=1100,Description="2019 Model Araba",ModelYear=2019
                },

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);  
        }
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);         
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(Car car)
        {
            Car carToGetById = _cars.SingleOrDefault(c => c.Id == car.Id);
            return carToGetById;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
