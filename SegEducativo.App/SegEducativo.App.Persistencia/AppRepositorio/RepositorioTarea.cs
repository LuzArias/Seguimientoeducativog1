using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SegEducativo.App.Dominio;
using System.Linq;
using System;


namespace SegEducativo.App.Persistencia
{

    public class RepositorioTarea : IRepositorioTarea

    {
        private readonly SegEducativo.App.Persistencia.AppContext _appContext = new AppContext();
       

        Tarea IRepositorioTarea.AddTarea(Tarea tarea)
        {
            var tareanueva = _appContext.Tareas.Add(tarea);
            _appContext.SaveChanges();
            return tareanueva.Entity;
        }

        void IRepositorioTarea.DeleteTarea(int Idtarea)
        {
            var tareaencontrada = _appContext.Tareas.FirstOrDefault(t => t.Id == Idtarea);
            if (tareaencontrada == null)
                return;
            _appContext.Tareas.Remove(tareaencontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Tarea> IRepositorioTarea.GetAllTarea()
        {
            return _appContext.Tareas;
        }

        Tarea IRepositorioTarea.GetTarea(int Idtarea)
        {
            var tareaencontrada = _appContext.Tareas.FirstOrDefault(t => t.Id == Idtarea);
            return tareaencontrada;
        }

        Tarea IRepositorioTarea.UpdateTarea(Tarea tarea)
        {
            var tareaencontrada = _appContext.Tareas.FirstOrDefault(t => t.Id == tarea.Id);
            if (tareaencontrada != null)
            {
            tareaencontrada.Nombre=tareaencontrada.Nombre;
            tareaencontrada.Id=tareaencontrada.Id;
            _appContext.SaveChanges();
            }
                    
                    return tarea;            
        }
    }
}
