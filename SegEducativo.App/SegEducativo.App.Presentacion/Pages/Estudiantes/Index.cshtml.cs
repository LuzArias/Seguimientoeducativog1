
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SegEducativo.App.Persistencia;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Presentacion.Pages.Estudiantes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoestudiante;
        public IEnumerable<Estudiante> Estudiantes {get; set;}
        public Estudiante Estudiante{get; set;}        
        public IndexModel(IRepositorioEstudiante _repoestudiante)
        {
            this._repoestudiante = _repoestudiante;
                this.onGet();      
      }
        
        
        public void onGet()
        
        {
            Estudiantes= _repoestudiante.GetAllEstudiante();
            
            }

        }
    }




