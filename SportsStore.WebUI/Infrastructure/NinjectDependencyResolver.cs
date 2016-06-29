using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Moq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //Setup IProductRepository
            Mock<IProductsRepository> mockIProductRepository = new Mock<IProductsRepository>();
            mockIProductRepository.Setup(s => s.Products).Returns(
                new List<Product>
                {
                     new Product() { Name="Football", Price = 25 },
                     new Product { Name = "Surf board", Price = 179 },
                     new Product { Name = "Running shoes", Price = 95 }
                });
            _kernel.Bind<IProductsRepository>().ToConstant(mockIProductRepository.Object);
            //TODO: there are no bindings
            
        }
    }
}