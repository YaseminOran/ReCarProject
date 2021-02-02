using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine("araç özelliği: {0}====>>>>Günlük fiyatı : {1}", product.Description, product.DailyPrice);
            }
           
        }
    }

    
}
