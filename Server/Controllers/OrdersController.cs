using DoAnBanSach.Server.Data;
using DoAnBanSach.Server.Models;
using DoAnBanSach.Server.Services;
using DoAnBanSach.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnBanSach.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly PaginationService _paginationService;
        private readonly UserStore _userStore;

        public OrdersController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager, PaginationService paginationService)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _paginationService = paginationService;
        }

        [HttpGet]
        public async Task<PaginationResponse<Order>> GetOrdersPagination(int page)
        {
            var list = await _dbContext.Orders
                .Include(o => o.Details)
                .ThenInclude(detail => detail.Book)
                .ToListAsync();
            return _paginationService.Paginate<Order>(list, page, 8);
        }

        [HttpPost("confirm/{orderId:int}")]
        public async Task<Order> ConfirmOrder(int orderId)
        {
            string employeeId;
            Request.Cookies.TryGetValue("userid", out employeeId);
            Order order = await _dbContext.Orders
                .Include(o => o.Details)
                .ThenInclude(detail => detail.Book)
                .FirstAsync(o => o.OrderId == orderId);
            order.Status = "Đã xác nhận";
            order.EmployeeId = employeeId;
            await _dbContext.SaveChangesAsync();
            return order;
        }

        [HttpGet("customer")]
        public async Task<List<Order>> GetMyOrders()
        {
            string customerId;
            Request.Cookies.TryGetValue("userid", out customerId);
            return await _dbContext.Orders
                .Include(o => o.Details)
                .ThenInclude(detail => detail.Book)
                .Where(o => o.CustomerId == customerId)
                .OrderByDescending(o => o.Date)
                .ToListAsync();
        }

        [HttpGet("customer/{customerId}")]
        public async Task<List<Order>> GetCustomerOrdersAsync(string? customerUsername)
        {
            string customerId = (await _userManager.FindByNameAsync(customerUsername)).Id;
            return await _dbContext.Orders
                .Include(o => o.Details)
                .ThenInclude(detail => detail.Book)
                .Where(o => o.CustomerId == customerId)
                .OrderByDescending(o => o.Date)
                .ToListAsync();
        }
    }
}
