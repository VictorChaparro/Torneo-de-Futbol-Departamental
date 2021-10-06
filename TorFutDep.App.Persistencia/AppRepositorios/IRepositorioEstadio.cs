using System.Collections.Generic;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public interface IRepositorioEstadio
    {
        IEnumerable<Estadio> GetAllEstadios();
        Estadio AddEstadio(Estadio estadio);
        Estadio UpdateEstadio(Estadio estadio);
        void DeleteEstadio(int idEstadio);
        Estadio GetEstadio(int idEstadio);
        Municipio AsignarMunicipio(int idEstadio, int idMunicipio);
    }
}