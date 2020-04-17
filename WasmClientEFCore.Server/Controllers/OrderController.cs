using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WasmClientEFCore.Db;

namespace WasmClientEFCore.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private WasmClientEFCoreDbContext Db { get; }

        public OrderController(WasmClientEFCoreDbContext db)
        {
            Db = db;
        }

        [HttpGet]
        public async Task<List<Order>> Get()
        {
            var orders = await Db.Orders.Include(x => x.OrderDetails).ToListAsync();

            return orders;
        }
    }
}