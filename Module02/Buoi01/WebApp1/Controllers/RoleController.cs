using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class RoleController : BaseController
    {
        public RoleController(SiteProvider provider) : base(provider) { }
        public IActionResult Index()
        {

            return View(provider.Role.GetRoles());
        }
        [HttpPost]
        public IActionResult Create(Role obj)
        {
            provider.Role.Add(obj);
            return Redirect("/role");
        }




        //RoleRepository roleRepository;
        //public RoleController(CSContext context)
        //{
        //    roleRepository = new RoleRepository(context);
        //}
        //public IActionResult Index()
        //{

        //    return View(roleRepository.GetRoles());
        //}
        //[HttpPost]
        //public IActionResult Create(Role obj)
        //{
        //    roleRepository.Add(obj);
        //    return Redirect("/role");
        //}
    }
}
