using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;

namespace WebApp1.Areas.Dashboard.Controllers
{
    [Area("dashboard")]
    public class HomeController : Controller
    {
        MemberRepository memberRepository;
        RoleRepository roleRepository;
        MemberInRoleRepository memberInRoleRepository;
        public HomeController(CSContext context)
        {
            memberRepository = new MemberRepository(context);
            roleRepository = new RoleRepository(context);
            memberInRoleRepository = new MemberInRoleRepository(context);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
