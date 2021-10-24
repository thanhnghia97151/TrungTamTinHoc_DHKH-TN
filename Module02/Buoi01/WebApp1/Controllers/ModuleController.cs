using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class ModuleController : Controller
    {
        //Khuyết điểm
        ModuleRepository repository;
        ModuleProfessorRepository moduleProfessorRepository;
        ProfressorRepository professorRepository;
        public ModuleController(CSContext context)
        {
            moduleProfessorRepository = new ModuleProfessorRepository(context);
            repository = new ModuleRepository(context);
            professorRepository = new ProfressorRepository(context);
        }
        public IActionResult Index()
        {
            ViewBag.modules = repository.GetModules();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Module obj)
        {
            repository.Add(obj);
            return Redirect("/module");
        }
        public IActionResult Detail(int id)
        {
            ViewBag.professors = professorRepository.GetProfessor();
            ViewBag.moduleProfessors = moduleProfessorRepository.GetModuleProfessorsByModule(id);
            return View(repository.GetModuleById(id));
        }
        [HttpPost]
        public IActionResult Detail(int id, int[] professorId)
        {
            List<ModuleProfessor> list = new List<ModuleProfessor>();
            foreach (var pid in professorId)
            {
                list.Add(new ModuleProfessor { ModuleId = id, ProfessorId = pid });
                
            }
            moduleProfessorRepository.Add(list);
            return Redirect($"/module/detail/{id}");
        }
    }
}
