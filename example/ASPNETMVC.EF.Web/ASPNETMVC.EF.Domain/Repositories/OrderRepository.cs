using ASPNETMVC.EF.Domain.Architecture;
using ASPNETMVC.EF.Domain.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVC.EF.Domain
{
    public class OrderRepository : IOrderRepository
    {
        private IShopContext _context;

        public OrderRepository(IUnitOfWork uow)
        {
            _context = uow.Context as IShopContext;
        }

        public void NewOrder(int userId, int productId)
        {
            _context.Orders.Add(new Order() { ProductId = productId, UserId = userId });
        }

     
    }
}
