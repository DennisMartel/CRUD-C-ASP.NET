using Crud.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crud.Pages.alumnos
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Alumno> Alumnos { get; set; }

        public async Task OnGet()
        {
            Alumnos = await _context.Alumnos.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var alumno = await _context.Alumnos.FindAsync(id);

            if (alumno == null) return NotFound();

            _context.Alumnos.Remove(alumno);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
