using Warehouse.Data;
using Warehouse.Models;

namespace Warehouse.Services
{
    public class WarehouseService
    {
        private readonly ApplicationDbContext _dbContext;

        public WarehouseService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual List<Order> GetOrders() => _dbContext.Orders.ToList();
    }
}