using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        private Product productToDelete;
        private object product;

        public InMemoryProductDal()
        {
            _products = new List<Product> { 
                new Product{Id=1,BrandId=1, ColorId=1, DailyPrice=300, ModelYear="2007",Description="BMW-Otomatik vites"},
                new Product{Id=2,BrandId=1, ColorId=1, DailyPrice=400, ModelYear="2019",Description="VOSVOS-Otomatik vites"},
                new Product{Id=3,BrandId=2, ColorId=1, DailyPrice=150, ModelYear="2015",Description="RENO-Düz vites"},
                new Product{Id=4,BrandId=2, ColorId=2, DailyPrice=100, ModelYear="2003",Description="TOFAŞ-Düz vites"},
                new Product{Id=5,BrandId=2, ColorId=2, DailyPrice=600, ModelYear="2020",Description="VOLVO-Otomatik vites"},





            };
        }
            
        public void Add(Product product)
        {

            _products.Add(product);
            
        }

        public void Delete(Product product)
        {
            productToDelete = _products.SingleOrDefault(p=>p.Id==product.Id);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;

        }

        public List<Product> GetById(int Id)
        {
            return _products.Where(p => p.Id == Id).ToList();
        }

        public void Update(Product product)
        {
            
           Product  productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            productToUpdate.Id = product.Id;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
        }
    }
}
