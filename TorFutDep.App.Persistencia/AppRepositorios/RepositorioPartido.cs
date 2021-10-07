using System.Collections.Generic;
using System.Linq;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly AppContext _appContext = new AppContext();

        Partido IRepositorioPartido.AddPartido(Partido partido)
        {
            var partidoAdicionado= _appContext.Partidos.Add(partido);
            _appContext.SaveChanges();
            return partidoAdicionado.Entity;
        }
        void IRepositorioPartido.DeletePartido(int idPartido)
        {
            var partidoEncontrado=_appContext.Partidos.Find(idPartido);
            if(partidoEncontrado==null)
                return;
            _appContext.Partidos.Remove(partidoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Partido> IRepositorioPartido.GetAllPartidos()
        {
            return _appContext.Partidos;
        }
        Partido IRepositorioPartido.GetPartido(int idPartido)
        {
            return _appContext.Partidos.Find(idPartido);
        }
        Partido IRepositorioPartido.UpdatePartido(Partido partido)
        {
            var partidoEncontrado=_appContext.Partidos.Find(partido.Id);
            if (partidoEncontrado!=null)
            {
                partidoEncontrado.FechaHora=partido.FechaHora;
                partidoEncontrado.Marcador_Inicial_Visitante=partido.Marcador_Inicial_Visitante;
                partidoEncontrado.Marcador_Inicial_Local=partido.Marcador_Inicial_Local;
                partidoEncontrado.Marcador_Final=partido.Marcador_Final;

                _appContext.SaveChanges();
            }
            return partidoEncontrado;
        }
        Estadio IRepositorioPartido.AsignarEstadio(int idPartido, int idEstadio)
        { 
            var partidoEncontrado = _appContext.Partidos.Find(idPartido);
            if (partidoEncontrado != null)
            {   
            var estadioEncontrado = _appContext.Estadios.Find(idEstadio);
            if (estadioEncontrado != null)
            { 
                partidoEncontrado.N_Estadio = estadioEncontrado;
                _appContext.SaveChanges();
            }
                return estadioEncontrado;
            }
            return null;
        }
        Arbitro IRepositorioPartido.AsignarArbitro(int idPartido, int idArbitro)
        { 
            var partidoEncontrado = _appContext.Partidos.Find(idPartido);
            if (partidoEncontrado != null)
            {   
            var arbitroEncontrado = _appContext.Arbitros.Find(idArbitro);
            if (arbitroEncontrado != null)
            { 
                partidoEncontrado.N_Arbitro = arbitroEncontrado;
                _appContext.SaveChanges();
            }
                return arbitroEncontrado;
            }
            return null;
        }
    }
}