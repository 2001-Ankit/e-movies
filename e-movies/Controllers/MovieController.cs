using e_movies.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_movies.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {
            var allmovies = _context.Movies.ToListAsync();
            return View();
        }
    }
}
