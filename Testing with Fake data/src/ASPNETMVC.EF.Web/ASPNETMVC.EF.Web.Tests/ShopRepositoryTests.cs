using ASPNETMVC.EF.Domain;
using ASPNETMVC.EF.Domain.Architecture;
using ASPNETMVC.EF.Domain.Model;
using ASPNETMVC.EF.Domain.Repositories;
using ASPNETMVC.EF.Domain.Testing;
using ASPNETMVC.EF.Web.Tests.Architecture;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVC.EF.Web.Tests
{
    [TestClass]
    public class ShopRepositoryTests
    {
        [TestMethod]
        public void GetOrdersByUserCountTest()
        {
            var customer = new User() { id = 1, username = "frederik" };
            using (var fakeCtx = new FakeShopContext())
            {
                fakeCtx.Orders.Add(new Order() { id = 1, UserId = customer.id });
                fakeCtx.Orders.Add(new Order() { id = 2, UserId = customer.id });
                fakeCtx.Orders.Add(new Order() { id = 3, UserId = 2 });

                using (var uow = new UnitOfWork<FakeShopContext>(fakeCtx))
                {
                    var repo = new ShopRepository(uow);
                    Assert.AreEqual(repo.GetOrdersByCustomer(customer).ToList().Count, 2);
                }
            }
        }

        [TestMethod]
        public void GetOrdersByUserCountTestMoq()
        {
            var customer = new User() { id = 1, username = "frederik" };

            IDbSet<Order> fakeDbSet = new OrderFakeDbSet();

            fakeDbSet.Add(new Order() { id = 1, UserId = customer.id });
            fakeDbSet.Add(new Order() { id = 2, UserId = customer.id });
            fakeDbSet.Add(new Order() { id = 3, UserId = 2 });

            var moq = new Moq.Mock<IShopContext>();
            moq.Setup(m => m.Orders).Returns(fakeDbSet);

            using (var uow = new UnitOfWork<FakeShopContext>(moq.Object))
            {
                var repo = new ShopRepository(uow);
                Assert.AreEqual(repo.GetOrdersByCustomer(customer).ToList().Count, 2);
            }
        }
 
    }
}
