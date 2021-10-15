
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SegEducativo.App.Persistencia;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Presentacion.Pages.Estudiantes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoestudiante;
        public IEnumerable<Estudiante> estudiantes {get; set;}
        public Estudiante estudiante{get; set;}        
        public IndexModel(IRepositorioEstudiante _repoestudiante)
        {
            this._repoestudiante = _repoestudiante;
                 this.onGet();        }
        
        
        public void onGet()
        
        {
            estudiantes= _repoestudiante.GetAllEstudiante();
            
            }

        }
    }




