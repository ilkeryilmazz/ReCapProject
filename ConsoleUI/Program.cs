using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using DataAccsess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCarDetails();
            //AddCar();
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Add(new Car
            {
                ModelYear = 2021,
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 1000,
                Description = "2021 Model araba"

            });
            Console.WriteLine(result.Message);
        }

        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " / " + car.CarName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
                Console.WriteLine(result.Message);
            }
            
            
                
            
            
            
            
        }
    }
}
