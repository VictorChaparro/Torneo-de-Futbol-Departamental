using System.Collections.Generic;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public interface IRepositorioEquipo
    {
        IEnumerable<Equipo> GetAllEquipos();
        Equipo AddEquipo(Equipo equipo);
        Equipo UpdateEquipo(Equipo equipo);
        void DeleteEquipo(int idEquipo);
        Equipo GetEquipo(int idEquipo);
        Director_Tecnico AsignarDirector_Tecnico(int idEquipo, int idDirector_Tecnico);
        Municipio AsignarMunicipio(int idEquipo, int idMunicipio);
    }
}