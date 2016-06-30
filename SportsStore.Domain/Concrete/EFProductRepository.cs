using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    public class EFProductRepository : IProductsRepository
    {
        private EFDbContext context = new EFDbContext();

        public EFProductRepository()
        {
            //Very simple object initializer
            if (context.Products.Count() == 0)
                Initialize();
        }
        public void Initialize()
        {
            for (int i = 0; i < 100; i++)
                context.Products.Add(new Product() { Name = $"Name{i.ToString("D3")}", Description = "D", Price = i + 100 ,Category = "CAT"+i/10});
            context.SaveChanges();
        }
        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }
    }
}
