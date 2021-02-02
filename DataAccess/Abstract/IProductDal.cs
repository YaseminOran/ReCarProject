using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IProductDal
    {
        List<Product> GetAll();
        List<Product> GetById(int Id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
