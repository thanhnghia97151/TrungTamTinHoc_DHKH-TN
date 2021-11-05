using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;
using NPOI.XSSF.UserModel; // -> Sử dụng cho file .xlxs
//using NPOI.HSSF.UserModel; -> Sử dụng cho file .xls
using NPOI.SS.UserModel;

namespace WebApp1.Controllers
{
    public class ModuleGroupController : Controller
    {
        ModuleGroupRepository moduleGroupRepository;
        public ModuleGroupController(CSContext context)
        {
            moduleGroupRepository = new ModuleGroupRepository(context);
        }
        public IActionResult Index()
        {
            //return View(moduleGroupRepository.GetModuleGroups().ToList());
            return View(moduleGroupRepository.GetModuleGroups().ToList());
        }
        [HttpPost]
        public IActionResult Create(IFormFile f)
        {
            string root = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data");
            //Tạo file ngẫu nhiên
            string filename = Guid.NewGuid().ToString() + Path.GetExtension(f.FileName);
            using (Stream stream = new FileStream(Path.Combine(root, filename), FileMode.Create))
            {
                f.CopyTo(stream);
            }
            int ret = moduleGroupRepository.Add(Path.Combine(root, filename));
            return Redirect("/modulegroup");
        }

        public IActionResult Excel(IFormFile f)
        {
            List<ModuleGroup> list = new List<ModuleGroup>();
             using(Stream stream = f.OpenReadStream())
            {
                XSSFWorkbook workbook = new XSSFWorkbook(stream);
                ISheet sheet = workbook.GetSheetAt(0);
                for (int i = 1; i < sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);
                    list.Add(new ModuleGroup
                    {
                        ModuleId = Convert.ToInt32(row.GetCell(0).NumericCellValue),
                        GroupId = Convert.ToInt32(row.GetCell(1).NumericCellValue)
                    });
                }
            }
            moduleGroupRepository.Add(list);
            return Redirect("/modulegroup");
        }
    }
}
