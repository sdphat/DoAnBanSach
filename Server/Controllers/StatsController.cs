using DoAnBanSach.Server.Data;
using DoAnBanSach.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoAnBanSach.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public StatsController(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        [HttpGet]
        public async Task<StatsResult> GetStatsAsync()
        {
            int products = _dbContext.Books.Count();
            int orders = _dbContext.Orders.Count();
            int customers = 3;
            int staffs = 2;
            return new StatsResult { Customers = customers, Staffs = staffs, Orders = orders, Products = products };
        }
    }
}
