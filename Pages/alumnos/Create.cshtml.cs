using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Crud.models;

namespace Crud.Pages.alumnos
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Alumno Alumno { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _context.Add(Alumno);

            await _context.SaveChangesAsync();
            
            return RedirectToPage("Index");
        }
    }
}
