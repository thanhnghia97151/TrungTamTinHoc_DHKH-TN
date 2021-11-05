using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.ViewModels;
using WebApp1.Models;
using WebApp1.Helper;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace WebApp1.Controllers
{

    public class AuthController : Controller
    {
        MemberRepository memberRepository;
        public AuthController(CSContext context)
        {
            memberRepository = new MemberRepository(context);
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterModel obj)
        {
            memberRepository.Add(new Member
            {
                Id = Helper.Helper.RandomString(32),
                Email = obj.Email,
                Gender = obj.Gender,
                Username = obj.Username,
                Password = Helper.Helper.Hash(obj.Password)
            }) ;
            return Redirect("/auth/login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel obj)
        {
            Member member = memberRepository.Login(obj);
            if (member!= null)
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,member.Username),
                    new Claim(ClaimTypes.Email,member.Email),
                    new Claim(ClaimTypes.Gender,member.Gender.ToString()),
                    new Claim(ClaimTypes.NameIdentifier,member.Id),
                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);
                AuthenticationProperties properties = new AuthenticationProperties
                {
                    IsPersistent = obj.Remember
                };
                await HttpContext.SignInAsync(principal, properties);
                return Redirect("/auth");
            }
            ModelState.AddModelError("", "Login Failed");
            return View(obj);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/auth/login");
        }
    }
}
