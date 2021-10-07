using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegEducativo.App.Dominio
{

    public class Estudiante : Persona
    {
        [ForeignKey("Materia")]
        public int Materia_id;
        public Materia Materia { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [ForeignKey("Acudiente")]
        public int Acudiente_id;
        public Acudiente Acudiente { get; set; }


    }
}