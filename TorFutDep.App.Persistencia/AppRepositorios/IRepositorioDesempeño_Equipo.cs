using System.Collections.Generic;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public interface IRepositorioDesempeño_Equipo
    {
        IEnumerable<Desempeño_Equipo> GetAllDesempeño_Equipos();
        Desempeño_Equipo AddDesempeño_Equipo(Desempeño_Equipo desempeño_equipo);
        Desempeño_Equipo UpdateDesempeño_Equipo(Desempeño_Equipo desempeño_equipo);
        void DeleteDesempeño_Equipo(int idDesempeño_Equipo);
        Desempeño_Equipo GetDesempeño_Equipo(int idDesempeño_Equipo);
        Equipo AsignarEquipo(int idDesempeño_Equipo, int idEquipo);
    }
}