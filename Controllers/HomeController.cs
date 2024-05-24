using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sbs.DAL;
using sbs.Models;

namespace sbs.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
    }
}
