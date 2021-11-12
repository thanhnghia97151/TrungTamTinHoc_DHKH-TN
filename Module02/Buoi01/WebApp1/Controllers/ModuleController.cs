using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    [Authorize(Roles ="admin")]
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
            // ViewBag.professors = professorRepository.GetProfessor();

            ViewBag.professors= professorRepository.GetProfessorsNotInModule(id);
            //-------------------------------------------------------------------
            //ViewBag.moduleProfessors = moduleProfessorRepository.GetModuleProfessorsByModule(id);

            //---------------------------------------------------------------------------
            //ViewBag.moduleProfessors = professorRepository.GetProfessorsByMoudleId(id);
            ViewBag.professsorsModule = professorRepository.GetProfessorsByMoudleId(id);
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


        //
        public IActionResult Browser(int id)
        {
            ViewBag.professors = professorRepository.GetProfessorCheckeds(id);
            return View(repository.GetModuleById(id));
        }
        //
        public IActionResult AddModuleProfessor(ModuleProfessor obj)
        {
            return Json(moduleProfessorRepository.Save(obj));
            //return Json(moduleProfessorRepository.Add(obj));
        }

        //

    }
}
