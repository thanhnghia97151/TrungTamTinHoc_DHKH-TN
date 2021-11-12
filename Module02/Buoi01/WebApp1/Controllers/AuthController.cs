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
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace WebApp1.Controllers
{

    public class AuthController : Controller
    {
        MemberRepository memberRepository;
        RoleRepository roleRepository;
        IConfiguration configuration;
        public AuthController(CSContext context,IConfiguration configuration)
        {
            this.configuration = configuration;
            roleRepository = new RoleRepository(context);
            memberRepository = new MemberRepository(context);
        }
        public IActionResult Password()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Password(ForgotPassword  obj)
        {
            string token = Helper.Helper.RandomString(32);
            obj.Token = token;
            int ret = memberRepository.Update(obj);
            if (ret>0)
            {
                IConfigurationSection section = configuration.GetSection("Email:Gmail");
                string url = $"<a href=\"https://localhost:44373/auth/reset/{token}\" > Click here Reset Password </a>";
                //Gửi Email
                SmtpClient client = new SmtpClient(section.GetSection("Host").Value, 587)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(section.GetSection("Address").Value, section.GetSection("Password").Value)
                };
                MailAddress from = new MailAddress(section.GetSection("Address").Value);
                MailAddress to = new MailAddress(obj.Email);
                MailMessage mailMessage = new MailMessage(from, to);
                mailMessage.Subject = "App Scheduling Reset Password";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = url;
                client.Send(mailMessage);
                TempData["email"] = obj.Email;
                return Redirect("/auth/sendsuccess");
            }
            ModelState.AddModelError("", "Email not found");
            return View(obj);
        }
        public IActionResult SendSuccess()
        {
            return View();
        }
        public  IActionResult Reset(string id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Reset(string id, ResetPassword obj)
        {
            obj.Token = id;
            int ret = memberRepository.Update(obj);
            if (ret>0)
            {
                return Redirect("/auth/login");
            }
            ModelState.AddModelError("", "Token Invalid");
            return View(obj);
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Change()
        {
            return View();
        }
        [Authorize,HttpPost]
        public IActionResult Change(ChangeModel obj)
        {
            obj.MemberId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int ret = memberRepository.ChangePassword(obj);
            if (ret == 0)
            {
                ModelState.AddModelError("", "Change Password Failed");
                return View(obj);
            }
            return Redirect("/auth/logut");
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
        public IActionResult Denied()
        {
            return View();
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
                // Thieu Role
                List<Role> roles = roleRepository.GetRolesByMemberId(member.Id);
                if (roles != null)
                {
                    foreach (var item in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, item.Name));
                    }
                }
                 
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
