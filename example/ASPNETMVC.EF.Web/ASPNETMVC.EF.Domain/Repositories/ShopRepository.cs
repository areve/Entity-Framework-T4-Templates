using ASPNETMVC.EF.Domain.Architecture;
using ASPNETMVC.EF.Domain.Model;
using ASPNETMVC.EF.Domain.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVC.EF.Domain.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private IShopContext _context;

        public ShopRepository(IUnitOfWork uow)
        {
            _context = uow.Context as IShopContext;
        }

        public IQueryable<Order> GetOrdersByCustomer(User user)
        {
            return _context.Orders.Where(o => o.UserId == user.id);
        }

        

    }

    
}
