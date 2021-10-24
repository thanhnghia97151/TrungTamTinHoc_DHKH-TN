using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class ProfessorController : Controller
    {
        ProfressorRepository repository;
        public ProfessorController(CSContext context)
        {
            repository = new ProfressorRepository(context);
        }
        public IActionResult Index()
        {
            return View(repository.GetProfessor());
        }
        [HttpPost]
        public IActionResult Create(Professor obj)
        {
            repository.Add(obj);
            return Redirect("/professor");
        }
    }
}
