using ASPNETMVC.EF.Domain.Architecture;
using ASPNETMVC.EF.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVC.EF.Domain
{
    public class ProductRepository : IProductRepository
    {
        private IShopContext _context;

        public ProductRepository(IUnitOfWork uow)
        {
            _context = uow.Context as IShopContext;
        }

        public void NewProduct(string name, string description)
        {
            _context.Products.Add(new Product() { name = name, description = description });
        }
        
    }
}
