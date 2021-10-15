using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegEducativo.App.Dominio
{

    public class Estudiante : Persona
    {
        public DateTime FechaNacimiento { get; set; }
        public List<Materia> Materias { get; set; } 
        public Acudiente Acudiente { get; set; }
        public List<Profesor> Profesores { get; set; }
        public List<Tarea> Tareas { get; set; }
        public List<Recomendaciones> Recomendaciones{ get; set; }


    }
}