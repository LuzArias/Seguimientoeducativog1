using System.Collections.Generic;
using SegEducativo.App.Dominio;
using System.Linq;



namespace SegEducativo.App.Persistencia
{

    public class RepositorioReco : IRepositorioReco

    {
        private readonly SegEducativo.App.Persistencia.AppContext _appContext = new AppContext();
       

        Recomendaciones IRepositorioReco.AddRecomendaciones(Recomendaciones recomendaciones)
        {
            var reconueva = _appContext.Recomendaciones.Add(recomendaciones);
            _appContext.SaveChanges();
            return reconueva.Entity;
        }

        void IRepositorioReco.DeleteRecomendaciones(int Idrecomendaciones)        {
            var recoencontrada = _appContext.Recomendaciones.FirstOrDefault(r => r.Id == Idrecomendaciones);
            if (recoencontrada == null)
                return;
            _appContext.Recomendaciones.Remove(recoencontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Recomendaciones> IRepositorioReco.GetAllRecomendaciones()
        {
            return _appContext.Recomendaciones;
        }

        Recomendaciones IRepositorioReco.GetRecomendaciones(int Idrecomendaciones)        {
            var recoencontrada = _appContext.Recomendaciones.FirstOrDefault(r => r.Id == Idrecomendaciones);
            return recoencontrada;
        }

        Recomendaciones IRepositorioReco.UpdateRecomendaciones(Recomendaciones recomendaciones)        {
            var recoencontrada = _appContext.Recomendaciones.FirstOrDefault(r => r.Id == recomendaciones.Id);
            if (recoencontrada != null)
            {
            recoencontrada.Nombre=recoencontrada.Nombre;
            recoencontrada.Id=recoencontrada.Id;
            _appContext.SaveChanges();
            }
                    
                    return recomendaciones;            
        }
    }
}
