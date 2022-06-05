using Crud.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Crud.Pages.alumnos
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Alumno Alumno { get; set; }

        public async Task OnGet(int id)
        {
            Alumno = await _context.Alumnos.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var alumnoFromDb = await _context.Alumnos.FindAsync(Alumno.Id);

                if (alumnoFromDb == null) return NotFound();

                alumnoFromDb.names = Alumno.names;
                alumnoFromDb.lastnames = Alumno.lastnames;
                alumnoFromDb.phone = Alumno.phone;
                alumnoFromDb.email = Alumno.email;
                alumnoFromDb.address = Alumno.address;
                alumnoFromDb.birthday = Alumno.birthday;

                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            return RedirectToPage();
        }
    }
}
