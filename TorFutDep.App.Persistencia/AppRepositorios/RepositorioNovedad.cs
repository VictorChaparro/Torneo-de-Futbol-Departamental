using System.Collections.Generic;
using System.Linq;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public class RepositorioNovedad : IRepositorioNovedad
    {
        private readonly AppContext _appContext = new AppContext();

        Novedad IRepositorioNovedad.AddNovedad(Novedad novedad)
        {
            var novedadAdicionado= _appContext.Novedades.Add(novedad);
            _appContext.SaveChanges();
            return novedadAdicionado.Entity;
        }
        void IRepositorioNovedad.DeleteNovedad(int idNovedad)
        {
            var novedadEncontrado=_appContext.Novedades.Find(idNovedad);
            if(novedadEncontrado==null)
                return;
            _appContext.Novedades.Remove(novedadEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Novedad> IRepositorioNovedad.GetAllNovedades()
        {
            return _appContext.Novedades;
        }
        Novedad IRepositorioNovedad.GetNovedad(int idNovedad)
        {
            return _appContext.Novedades.Find(idNovedad);
        }
        Novedad IRepositorioNovedad.UpdateNovedad(Novedad novedad)
        {
            var novedadEncontrado=_appContext.Novedades.Find(novedad.Id);
            if (novedadEncontrado!=null)
            {
                novedadEncontrado.FechaHora=novedad.FechaHora;
                novedadEncontrado.N_Tipo_Novedad=novedad.N_Tipo_Novedad;

                _appContext.SaveChanges();
            }
            return novedadEncontrado;
        }
        Equipo IRepositorioNovedad.AsignarEquipo(int idNovedad, int idEquipo)
        { 
            var novedadEncontrado = _appContext.Novedades.Find(idNovedad);
            if (novedadEncontrado != null)
            {   
            var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
            if (equipoEncontrado != null)
            { 
                novedadEncontrado.N_Equipo= equipoEncontrado;
                _appContext.SaveChanges();
            }
                return equipoEncontrado;
            }
            return null;
        }
        Jugador IRepositorioNovedad.AsignarJugador(int idNovedad, int idJugador)
        { 
            var novedadEncontrado = _appContext.Novedades.Find(idNovedad);
            if (novedadEncontrado != null)
            {   
            var jugadorEncontrado = _appContext.Jugadores.Find(idJugador);
            if (jugadorEncontrado != null)
            { 
                novedadEncontrado.N_Jugador = jugadorEncontrado;
                _appContext.SaveChanges();
            }
                return jugadorEncontrado;
            }
            return null;
        }
        Partido IRepositorioNovedad.AsignarPartido(int idNovedad, int idPartido)
        { 
            var novedadEncontrado = _appContext.Novedades.Find(idNovedad);
            if (novedadEncontrado != null)
            {   
            var partidoEncontrado = _appContext.Partidos.Find(idPartido);
            if (partidoEncontrado != null)
            { 
                novedadEncontrado.N_Partido = partidoEncontrado;
                _appContext.SaveChanges();
            }
                return partidoEncontrado;
            }
            return null;
        }
    }
}