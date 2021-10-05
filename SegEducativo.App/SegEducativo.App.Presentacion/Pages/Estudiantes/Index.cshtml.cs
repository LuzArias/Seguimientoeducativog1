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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public IEnumerable<Estudiante> estudiante {get; set;}
        
        public IndexModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante = _repoEstudiante;
                   
        }
        
        public void onGet()
        
        {
            estudiante= _repoEstudiante.GetAllEstudiante();
            foreach(var x in estudiante){
                var z=x.Nombre;
            }

        }
    }
}



