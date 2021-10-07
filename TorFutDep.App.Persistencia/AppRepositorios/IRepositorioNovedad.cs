using System.Collections.Generic;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public interface IRepositorioNovedad
    {
        IEnumerable<Novedad> GetAllNovedades();
        Novedad AddNovedad(Novedad novedad);
        Novedad UpdateNovedad(Novedad novedad);
        void DeleteNovedad(int idNovedad);
        Novedad GetNovedad(int idNovedad);
        Equipo AsignarEquipo(int idNovedad, int idEquipo);
        Jugador AsignarJugador(int idNovedad, int idJugador);
        partido AsignarPartido(int idNovedad, int idPartido);
    }
}