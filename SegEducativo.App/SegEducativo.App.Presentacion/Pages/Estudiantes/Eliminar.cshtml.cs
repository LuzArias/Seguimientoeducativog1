using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SegEducativo.App.Dominio;
using SegEducativo.App.Persistencia;

namespace SegEducativo.App.Presentacion.Pages.Estudiantes
{
    public class EliminarModel : PageModel
    {
        private readonly IRepositorioEstudiante _appContext;
        public Estudiante Estudiante { get; set; }
        public EliminarModel(IRepositorioEstudiante _appContext)

        {
            this._appContext = _appContext;
        }
        public IActionResult OnGet(int Id)
        {
            Estudiante = _appContext.GetEstudiante(Id);

            if (Estudiante== null)
            {
                return NotFound();
            }
            else return Page();
        }
    

    public IActionResult OnPost(int Id)
    {
        _appContext.DeleteEstudiante(Id);

        return RedirectToPage("Index");

    }
}
}
