using DoAnBanSach.Server.Models;
using DoAnBanSach.Shared;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Linq;

namespace DoAnBanSach.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly IUserClaimsPrincipalFactory<ApplicationUser> _claimsPrincipalFactory;

        public AuthController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IUserStore<ApplicationUser> userStore, IUserClaimsPrincipalFactory<ApplicationUser> claimsPrincipalFactory)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userStore = userStore;
            _claimsPrincipalFactory = claimsPrincipalFactory;
        }

        [HttpPost("logout")]
        public async Task Logout()
        {
            var user = User;
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);
        }

        [HttpPost("login")]
        public async Task<string?> Login()
        {
            LoginPayload data;
            try
            {
                data = await Request.ReadFromJsonAsync<LoginPayload>();
            } catch(Exception ex)
            {
                Response.StatusCode = (int) System.Net.HttpStatusCode.BadRequest;
                return string.Empty;
            }

            var user = await _userManager.FindByNameAsync(data.Username);
            if(user == null)
            {
                Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                return "Sai tên đăng nhập hoặc mật khẩu";
            }
            var result = await _signInManager.CheckPasswordSignInAsync(user, data.Password, false);
            if(!result.Succeeded)
            {
                Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                return "Sai tên đăng nhập hoặc mật khẩu";
            }
            var user1 = await _claimsPrincipalFactory.CreateAsync(user);
            var identity = user1.Identity as ClaimsIdentity;
            await _signInManager.SignInWithClaimsAsync(user, true, identity.Claims);
            Response.Cookies.Append("userid", user.Id);
            return string.Empty;
        }

        [HttpPost("register")]
        public async Task<string> Register()
        {
            RegisterPayload registerPayload;
            try
            {
                registerPayload = await Request.ReadFromJsonAsync<RegisterPayload>();
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                return "Wrong format";
            }
            var user = new ApplicationUser { UserName = registerPayload.Username, PhoneNumber = registerPayload.PhoneNumber, Email = registerPayload.Username };
            await _userStore.SetUserNameAsync(user, user.UserName, CancellationToken.None);
            var result = await _userManager.CreateAsync(user, registerPayload.Password);
            await _userManager.AddToRoleAsync(user, "USER");
            if (!result.Succeeded)
            {
                Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                return "Tên đăng nhập đã tồn tại";
                // Debugging code
                //return string.Join("\n", result.Errors.Select(e => e.Description));
            }
            await _signInManager.SignInAsync(user, isPersistent: true);
            Response.Cookies.Append("userid", user.Id);
            return "";
        }
    }
}
