using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace SegEducativo.App.Dominio

{
    public class Profesor : Persona
    {
        public List<Grupo> Grupos { get; set; }
    }
}

