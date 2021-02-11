using Core.DataAccsess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand,ReCapProjectContext>, IBrandDal
    {
      
    }
}
