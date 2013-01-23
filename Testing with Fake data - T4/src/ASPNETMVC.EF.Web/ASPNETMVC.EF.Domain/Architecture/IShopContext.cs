using ASPNETMVC.EF.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVC.EF.Domain.Architecture
{
    public interface IShopContext : IContext
    {
        IDbSet<Order> Orders { get;  }
        IDbSet<Product> Products { get;  }
        IDbSet<User> Users { get;  }
    }
}
