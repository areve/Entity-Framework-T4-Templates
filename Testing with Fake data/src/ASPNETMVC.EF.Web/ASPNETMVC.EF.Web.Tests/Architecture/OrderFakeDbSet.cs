using ASPNETMVC.EF.Domain.Model;
using ASPNETMVC.EF.Domain.Testing;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVC.EF.Web.Tests.Architecture
{
    public class OrderFakeDbSet : FakeDbSet<Order>
    {
        public override Order Find(params object[] values)
        {
            var value = (int)values.FirstOrDefault();
            return this.SingleOrDefault(o => o.id == value);
        }
    }

    

}
