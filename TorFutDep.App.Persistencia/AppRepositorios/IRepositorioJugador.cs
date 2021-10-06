using System.Collections.Generic;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public interface IRepositorioJugador
    {
        IEnumerable<Jugador> GetAllJugadores();
        Jugador AddJugador(Jugador jugador);
        Jugador UpdateJugador(Jugador jugador);
        void DeleteJugador(int idJugador);
        Jugador GetJugador(int idJugador);
        Equipo AsignarEquipo(int idJugador, int idEquipo);
    }
}