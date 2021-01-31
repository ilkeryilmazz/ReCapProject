using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<Car> GetAll()
        {
            return _cars;
        }
        public Car GetById(Car car)
        {
            Car carToGetById = _cars.SingleOrDefault(c => c.Id == car.Id);
            return carToGetById;
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = 150;
            carToUpdate.Description = "Güncellenen araba";  
        }
    }
}
