using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SegEducativo.App.Dominio;
using SegEducativo.App.Persistencia;

namespace SegEducativo.App.Presentacion.Pages.Estudiantes
{
    public class EliminarModel : PageModel
    {
        private readonly IRepositorioEstudiante RepositorioEstudiante;
        [BindProperty]
        public Estudiante Estudiante { get; set; }

        public EliminarModel()

        {
            this.RepositorioEstudiante =new RepositorioEstudiante();
            
        }
        public IActionResult OnGet(int? Id)
        {
            if (Id.HasValue)
            {
                 Estudiante = RepositorioEstudiante.GetEstudiante(Id.Value);

            }
           

            if (Estudiante== null)
            {
                return NotFound();
            }
            else return Page();
        }
    

    public IActionResult OnPost()
    {
        if(!ModelState.IsValid)
        {
             return Page();
        }

        if(Estudiante.Id>0)
        {
            RepositorioEstudiante.DeleteEstudiante(Estudiante.Id);

        }     
         return Page();
        }   

     
    }
}


