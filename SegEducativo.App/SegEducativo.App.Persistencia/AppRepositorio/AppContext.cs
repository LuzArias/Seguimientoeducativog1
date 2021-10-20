using Microsoft.EntityFrameworkCore;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Persistencia
{
    public class AppContext : DbContext
    {

        public DbSet<Persona> Persona { get; set; }
        public DbSet<Acudiente> Acudiente { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Recomendaciones> Recomendaciones { get; set; }


protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
     {

         if (!optionsBuilder.IsConfigured){
             optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLlocalDB; Initial Catalog=Educativoapp.Data");


         }


     }
    }
}









