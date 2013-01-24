using ASPNETMVC.EF.Domain.Architecture;
using ASPNETMVC.EF.Domain.Model;
using ASPNETMVC.EF.Domain.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVC.EF.Web.Tests.Architecture
{
    public class FakeShopContext : IShopContext
    {
        public FakeShopContext()
        {
            Orders = new OrderFakeDbSet();
        }
        public System.Data.Entity.IDbSet<Order> Orders
        {
            get;
            private set;
        }

        public System.Data.Entity.IDbSet<Product> Products
        {
            get;
            private set;
        }

        public System.Data.Entity.IDbSet<User> Users
        {
            get;
            private set;
        }

        public int SaveChanges()
        {
            return 0;
        }

        public void SetModified(object entity)
        {
           
        }

        public void SetAdded(object entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            
        }
    }
}
