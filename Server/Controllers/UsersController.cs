using DoAnBanSach.Server.Data;
using DoAnBanSach.Server.Models;
using DoAnBanSach.Server.Services;
using DoAnBanSach.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DoAnBanSach.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly PaginationService _paginationService;

        public UsersController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager, PaginationService paginationService)
        {
            _dbContext = applicationDbContext;
            _userManager = userManager;
            _paginationService = paginationService;
        }
        [HttpGet]
        public PaginationResponse<PublicUser> GetUsersAsync(int page)
        {
            var list = _userManager.Users.Select(u => new PublicUser { Email = u.Email, Username = u.UserName, PhoneNumber = u.PhoneNumber }).ToList();
            return _paginationService.Paginate<PublicUser>(list, page, 8);
        }
    }
}
