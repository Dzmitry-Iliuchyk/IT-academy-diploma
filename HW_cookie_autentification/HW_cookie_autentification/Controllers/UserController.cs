using AutoMapper;
using HW_cookie_autentification.DataAccess.Repositories.UserRepositories;
using HW_cookie_autentification.Filters;
using HW_cookie_autentification.Models.UserModels;
using HW_cookie_autentification.Models.UserModels.UserDTOs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HW_cookie_autentification.Controllers
{
    [UserActionFilter]
    public class UserController : Controller
    {
        private readonly UserRepository _repository;
        private readonly IMapper _mapper;

        public UserController(UserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO login)
        {
            try
            {
                var user = _mapper.Map<User>(login);
                var userinDb = await _repository.GetDetailsByEmail(login.Email);

                if (userinDb is null)
                {
                    return BadRequest("User is not exist");
                }
                if (userinDb.Password != login.Password) { return BadRequest("Incorrect password"); }
                await Authenticate(userinDb.Email, userinDb.Role);
                return Redirect("/User");
            }
            catch (Exception)
            {
                return BadRequest("User is not exist");
            }
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("Cookies");
            return Redirect("/User");

        }

        [HttpPost]
        [ActionName("Register")]
        public async Task<IActionResult> Registration([Bind("Email,Password,PasswordConfirm,Role")] RegisterDTO register)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = _mapper.Map<User>(register);
                    await _repository.Create(user);
                    return Redirect("/User");
                }
                catch (Exception)
                {

                    return BadRequest();
                }
            }
            return Redirect("/User/Register");


        }
        [HttpGet]
        [ActionName("Register")]
        public async Task<IActionResult> Registration()
        {
            return View();
        }
        [HttpGet]
        [ActionName("Login")]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        private async Task Authenticate(string email, string role)
        {
            var claims = new List<Claim>
        {
            new (ClaimsIdentity.DefaultNameClaimType, email),
            new (ClaimsIdentity.DefaultRoleClaimType, role)

        };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        }
    }
}
