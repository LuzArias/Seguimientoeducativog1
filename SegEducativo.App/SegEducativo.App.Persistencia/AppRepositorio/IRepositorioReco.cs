using System.Collections.Generic;
using SegEducativo.App.Dominio;

namespace SegEducativo.App.Persistencia
{
public interface IRepositorioReco
{
    
    IEnumerable<Recomendaciones> GetAllRecomendaciones();
    Recomendaciones AddRecomendaciones (Recomendaciones recomendaciones);
    Recomendaciones UpdateRecomendaciones (Recomendaciones recomendaciones);
    void DeleteRecomendaciones (int Idrecomendaciones);
    Recomendaciones GetRecomendaciones (int Idrecomendaciones);    
    
}
}