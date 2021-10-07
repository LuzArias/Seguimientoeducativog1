using  Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SegEducativo.App.Dominio;
using System.Linq;
using System;
using SegEducativo.App.Persistencia;

namespace Consola
{
    class Program
    {
        private static IRepositorioEstudiante _repoEstudiante=new RepositorioEstudiante(new SegEducativo.App.Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("prueba crud!");
            AddEstudiante();
             //buscarestudiante(2);
        }

        private static void AddEstudiante()
        {
            AddEstudiante("2000");
        }

        private static void AddEstudiante(string v)
        {
            var Estudiante=new Estudiante
            {
              Nombre="Ana",
              Apellidos="perez",
              Celular="1245",
              Genero=Genero.femenino,
              Direccion="calle sin fin",
              Ciudad="Bogota",
              Correo="luzp@",
              Materia_id = 1,
              Acudiente_id = 4,
              FechaNacimiento=new DateTime(2005),
                                                    
        };
            _repoEstudiante.AddEstudiante(Estudiante);
        }
        private static void buscarestudiante(int IdEstudiante)
        {
          var Estudiante = _repoEstudiante.GetEstudiante(IdEstudiante);
        Console.WriteLine(Estudiante.Nombre+" "+Estudiante.Apellidos);

        }
    }
}