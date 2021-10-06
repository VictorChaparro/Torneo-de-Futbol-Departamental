using System.Collections.Generic;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public interface IRepositorioPartido
    {
        IEnumerable<Partido> GetAllPartidos();
        Partido AddPartido(Partido partido);
        Partido UpdatePartido(Partido partido);
        void DeletePartido(int idPartido);
        Partido GetPartido(int idPartido);
        
    }
}