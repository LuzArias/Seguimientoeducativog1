using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SegEducativo.App.Persistencia;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Presentacion.Pages.Estudiantes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoestudiante;
        public IEnumerable<Estudiante> estudiantes {get; set;}
        
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




