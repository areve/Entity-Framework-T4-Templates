using ASPNETMVC.EF.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVC.EF.Domain.Architecture
{
    public interface IOrderRepository
    {
        void NewOrder(int userId, int productId);
    }
}
