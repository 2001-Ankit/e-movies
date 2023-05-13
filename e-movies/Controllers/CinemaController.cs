using e_movies.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_movies.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext _context;

        public CinemaController(AppDbContext context)
        {
            _context = context;
        }

        public async  Task <IActionResult> Index()
        {
           var allcinema = await _context.Producers.ToListAsync();
            return View();
        }
    }
}
