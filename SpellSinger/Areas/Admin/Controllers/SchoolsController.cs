using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpellSinger.Areas.Admin.Models;
using SpellSinger.Data;

namespace SpellSinger.Areas.Admin.Controllers
{
    public class SchoolsController(AppDbContext dbContext) : AdminBaseController
    {
        public async Task<IActionResult> Index()
        {
            var schools = await dbContext.Schools.ToListAsync();

            var model = schools.Select(p => new SchoolViewModel
            {
                Name = p.Name!,
                Color = p.Color,
                Description = p.Description,
                ImageUrl = p.ImageUrl
            });
            return View(model);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SchoolViewModel model)
        {
            if (ModelState.IsValid)
            {
                var school = new Domain.School
                {
                    Name = model.Name,
                    Color = model.Color,
                    Description = model.Description,
                    ImageUrl = model.ImageUrl
                };
                dbContext.Schools.Add(school);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
