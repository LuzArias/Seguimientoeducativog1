using System.Collections.Generic;
using SegEducativo.App.Dominio;
using System.Linq;
using System.Collections;



namespace SegEducativo.App.Persistencia
{
    public class RepositorioEstudiante : IRepositorioEstudiante

    {
        private readonly AppContext _appContext = new AppContext();                      
        
    
        public Estudiante AddEstudiante(Estudiante Estudiante)
        {
            var estudiantenuevo = _appContext.Estudiante.Add(Estudiante);
            _appContext.SaveChanges();
            return estudiantenuevo.Entity;
        }

        public void DeleteEstudiante(int IdEstudiante)
        {
            var estudiantencontrado = _appContext.Estudiante.FirstOrDefault(e => e.Id == IdEstudiante);
            if (estudiantencontrado != null)
                return;
            _appContext.Estudiante.Remove(estudiantencontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiante()
        {
            return _appContext.Estudiante;
        }

        public Estudiante GetEstudiante(int IdEstudiante)
        {
            var estudiantencontrado = _appContext.Estudiante.FirstOrDefault(e => e.Id == IdEstudiante);
            return estudiantencontrado;
        }

        public Estudiante UpdateEstudiante(Estudiante Estudiante)
        {
            var estudiantencontrado = _appContext.Estudiante.FirstOrDefault(e => e.Id == Estudiante.Id);
            if (estudiantencontrado != null)

            {

                estudiantencontrado.Nombre = Estudiante.Nombre;
                estudiantencontrado.Apellidos = Estudiante.Apellidos;
                estudiantencontrado.Direccion = Estudiante.Direccion;
                estudiantencontrado.Ciudad = Estudiante.Ciudad;
                estudiantencontrado.Correo = Estudiante.Correo;
                estudiantencontrado.Celular = Estudiante.Celular;
                estudiantencontrado.Genero = Estudiante.Genero;
                estudiantencontrado.FechaNacimiento = Estudiante.FechaNacimiento;
                _appContext.SaveChanges();
            }
            return estudiantencontrado;
        }

    }

}




