using Cial.Data;
using Cial.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cial.Areas.Admin.Controllers
{
    public class TeamController : Controller
    {
        public TeamDbContext _context;
        public TeamController(TeamDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.TeamData.Where(x => !x.IsDeleted).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(OurTeam TeamModel) 
        {
            _context.TeamData.Add(TeamModel); 
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");
        }

    }
}
