using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            estudiantes=new Estudiante();
        }
        public IActionResult onPost(Estudiante Estudiante)
        {
            if (Estudiante is null)
            {
                throw new ArgumentNullException(nameof(Estudiante));
            }
        }

        _repoestudiante.AddEstudiante(estudiantes);
            return RedirectToPageResult("Index")

        }
    }
}
