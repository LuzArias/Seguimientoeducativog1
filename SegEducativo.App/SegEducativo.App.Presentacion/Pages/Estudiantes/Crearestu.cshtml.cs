using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SegEducativo.App.Persistencia;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Presentacion.Pages.Estudiantes
{
    public class CrearestuModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoestudiante;
        public Estudiante estudiantes {get; set;}
        public CrearestuModel (IRepositorioEstudiante _repoestudiante)
        {
            this._repoestudiante=_repoestudiante;
        }
        public void OnGet()
        {
            //estudiantes=new Estudiante();
        }
        public IActionResult OnPost(Estudiante estudiantes)
        {
            _repoestudiante.AddEstudiante(estudiantes);
            return RedirectToPage("Index");
            
            {
                
            }
        }
    }
}  
    
