using System.Collections.Generic;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Persistencia
{
public interface IRepositorioTarea
{
    
    IEnumerable<Tarea> GetAllTarea();
    Tarea AddTarea (Tarea tarea);
    Tarea UpdateTarea (Tarea tarea);
    void DeleteTarea (int Idmateria);
    Tarea GetTarea (int Idtarea);    
    
}
}