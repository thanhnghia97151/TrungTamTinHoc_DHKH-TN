using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class MemberController : Controller
    {
        MemberInRoleRepository memberInRoleRepository;
        RoleRepository roleRepository;
        MemberRepository memberRepository;
        public MemberController(CSContext context) 
        {
            memberInRoleRepository = new MemberInRoleRepository(context);
            roleRepository = new RoleRepository(context);
            memberRepository = new MemberRepository(context);
        }
        public IActionResult Index()
        {
            return View(memberRepository.GetMembers());
        }

        public IActionResult Role(string id)
        {
            ViewBag.roles = roleRepository.GetRoleCheckeds(id);
            return View(memberRepository.GetMemberById(id));
        }
        [HttpPost]
        public IActionResult AddRole(MemberInRole obj)
        {
            return Json(memberInRoleRepository.Add(obj));
        }
    }
}
