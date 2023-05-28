using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Workshop.DataContext;
using Workshop.Models;
using Workshop.Src.Entity;

namespace Workshop.Controllers;

public class FacultyController : Controller
{
    private readonly AppDbContext _context;

    public FacultyController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var list = await _context.Faculties.OrderBy(x => x.Id).ToListAsync();
        return View(list);
    }

    public async Task<IActionResult> Create()
    {
        return View(new FacultyVm());
    }

    [HttpPost]
    public async Task<IActionResult> Create(FacultyVm model)
    {
        try
        {
            var faculty = new Faculty()
            {
                Name = model.Name,
                Description = model.Description
            };
            await _context.Faculties.AddAsync(faculty);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


}