using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace SegEducativo.App.Dominio

{
    public class Profesor : Persona
    {
        [ForeignKey("Grupo")]
        public int Grupo_id;
        public Grupo Grupo { get; set; }
        
        public IEnumerable<Estudiante> Estudiantes { get; set; }
    }
}

