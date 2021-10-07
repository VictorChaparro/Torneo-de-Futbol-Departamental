using System.Collections.Generic;
using System.Linq;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly AppContext _appContext = new AppContext();

        Jugador IRepositorioJugador.AddJugador(Jugador jugador)
        {
            var jugadorAdicionado= _appContext.Jugadores.Add(jugador);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        }
        void IRepositorioJugador.DeleteJugador(int idJugador)
        {
            var jugadorEncontrado=_appContext.Jugadores.Find(idJugador);
            if(jugadorEncontrado==null)
                return;
            _appContext.Jugadores.Remove(jugadorEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Jugador> IRepositorioJugador.GetAllJugadores()
        {
            return _appContext.Jugadores;
        }
        Jugador IRepositorioJugador.GetJugador(int idJugador)
        {
            return _appContext.Jugadores.Find(idJugador);
        }
        Jugador IRepositorioJugador.UpdateJugador(Jugador jugador)
        {
            var jugadorEncontrado=_appContext.Jugadores.Find(jugador.Id);
            if (jugadorEncontrado!=null)
            {
                jugadorEncontrado.Nombre_Jugador=jugador.Nombre_Jugador;
                jugadorEncontrado.Tipos_Posiciones=jugador.Tipos_Posiciones;

                _appContext.SaveChanges();
            }
            return jugadorEncontrado;
        }
        Equipo IRepositorioJugador.AsignarEquipo(int idJugador, int idEquipo)
        { 
            var jugadorEncontrado = _appContext.Jugadores.Find(idJugador);
            if (jugadorEncontrado != null)
            {   
            var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
            if (equipoEncontrado != null)
            { 
                jugadorEncontrado.N_Equipo = equipoEncontrado;
                _appContext.SaveChanges();
            }
                return equipoEncontrado;
            }
            return null;
        }
    }
}