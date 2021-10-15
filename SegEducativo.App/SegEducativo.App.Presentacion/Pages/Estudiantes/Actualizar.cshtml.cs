using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SegEducativo.App.Dominio;
using SegEducativo.App.Persistencia;

namespace SegEducativo.App.Presentacion.Pages.Estudiantes
{
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoestudiante;
        public Estudiante estudiante { get; set; }
        public ActualizarModel(IRepositorioEstudiante _repoestudiante)

        {
            this._repoestudiante = _repoestudiante;
        }
        public IActionResult OnGet(int Id)
        {
            estudiante = _repoestudiante.GetEstudiante(Id);

            if (estudiante == null)
            {
                return NotFound();
            }
            else return Page();
        }
    
public IActionResult OnPost(Estudiante Estudiante)
{
    _repoestudiante.UpdateEstudiante(Estudiante);

    return RedirectToPage("Index");

}
    

}
}
