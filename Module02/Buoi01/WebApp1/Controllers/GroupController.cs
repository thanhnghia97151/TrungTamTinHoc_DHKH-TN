using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;
using System.IO;

namespace WebApp1.Controllers
{
    public class GroupController : Controller
    {
        GroupRepository groupRepository;
        public GroupController(CSContext context)
        {
            groupRepository = new GroupRepository(context);
        }
        public IActionResult Index()
        {
            return View(groupRepository.GetGroups());
        }
        [HttpPost]
        public IActionResult Create(IFormFile f)
        {
            List<Group> groups = new List<Group>();
            //return Json(f.FileName);
            using (StreamReader stream= new StreamReader(f.OpenReadStream()))
            {
                
                string line = stream.ReadLine();
                while((line = stream.ReadLine())!=null)
                {
                    string[] a = line.Split(',');
                    groups.Add(new Group
                    {
                        Id = int.Parse(a[0]),
                        Size = short.Parse(a[1])
                    });
                }
            }
            groupRepository.Add(groups);
            return Redirect("/group");
        }
    }
}
