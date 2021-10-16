
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SegEducativo.App.Persistencia;
using SegEducativo.App.Dominio;
using System.Collections;

namespace SegEducativo.App.Presentacion.Pages.Estudiantes
{
    public class TareaModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public Estudiante estudiantes{get; set;}
        public Tarea tarea{get; set;}
        public TareaModel (IRepositorioEstudiante _repoEstudiante)
        {

            this._repoEstudiante=_repoEstudiante;
        }
        public  IActionResult OnGet(int Id)
        {
            estudiantes=_repoEstudiante.GetEstudiante(Id);
            if (estudiantes!=null)
            {
                 return Page();
            }
            else 
            {
                return NotFound();
            }
        }
        public IActionResult OnPost(int Id, Tarea tarea)
        {
            _repoEstudiante.AddTarea(Id,tarea);
            return RedirectToPage("Crearestu");
        }
    }
}
