using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Telerik.JustMock;
using Warehouse.Data;
using Warehouse.Models;
using Warehouse.Services;

namespace Warehouse.JustMockTest
{
    /// <summary>
    /// Summary description for JustMockTest
    /// </summary>
    [TestClass]
    public class JustMockTest
    {
        [TestMethod]
        public void GetOrders_AreEqualsOne()
        {
            //Arrange
            var dbContext = new ApplicationDbContext();
            Mock.Arrange(() => dbContext.Orders).ReturnsCollection(FakeOrders());
            WarehouseService service = Mock.Create<WarehouseService>();
            Mock.Arrange(() => service.GetOrders()).Returns(dbContext.Orders.ToList());

            //Action
            var query = from o in dbContext.Orders
                        where o.Id == 1
                        select o;

            var queryService = from s in service.GetOrders()
                               where s.Id == 1
                               select s;

            // Assert
            Assert.AreEqual(1, query.Count());
            Assert.AreEqual(1, query.First().Id);

            Assert.AreEqual(1, queryService.Count());
            Assert.AreEqual(1, queryService.First().Id);
        }

        public IList<Order> FakeOrders()
        {
            var order = new Order();
            order.Id = 1;
            order.ProductName = "Smartphone";
            order.Quantity = 53;
            order.IsCompleted = true;

            var fakeOrders = new List<Order>();
            fakeOrders.Add(order);

            return fakeOrders;
        }
    }
}
