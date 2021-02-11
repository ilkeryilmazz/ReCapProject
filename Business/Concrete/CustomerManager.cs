using Business.Abstract;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult("Müşteri eklendi");
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult("Müşteri silindi");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),"Müşteriler getirildi");
        }

        public IDataResult<Customer> GetById(int Id)
        {
            
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.UserId == Id),"Müşteri id ile getirildi");
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult("Müşteri güncellendi");
        }
    }
}
