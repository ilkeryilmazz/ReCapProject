using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.AddedCar);  
        }
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.DeletedCar);
        }
        public IDataResult<List<Car>> GetAll()
        {
          return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.ListedCar);
        }

        public IDataResult<Car> GetById(int id)
        {
           return new SuccessDataResult<Car>(_carDal.Get(p=>p.Id==id),Messages.ListedCarById);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.ListedCarDetails);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id),Messages.ListedCarsByBrandId);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id),Messages.ListedCarsByColorId);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.UpdatedCar);
        }
    }
}
