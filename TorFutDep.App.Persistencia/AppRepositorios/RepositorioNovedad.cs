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
        Estadio IRepositorioNovedad.AsignarEstadio(int idNovedad, int idEstadio)
        { 
            var novedadEncontrado = _appContext.Novedades.Find(idNovedad);
            if (novedadEncontrado != null)
            {   
            var estadioEncontrado = _appContext.Estadios.Find(idEstadio);
            if (estadioEncontrado != null)
            { 
                novedadEncontrado.N_Estadio = estadioEncontrado;
                _appContext.SaveChanges();
            }
                return estadioEncontrado;
            }
            return null;
        }
        Arbitro IRepositorioNovedad.AsignarArbitro(int idNovedad, int idArbitro)
        { 
            var novedadEncontrado = _appContext.Novedades.Find(idNovedad);
            if (novedadEncontrado != null)
            {   
            var arbitroEncontrado = _appContext.Arbitros.Find(idArbitro);
            if (arbitroEncontrado != null)
            { 
                novedadEncontrado.N_Arbitro = arbitroEncontrado;
                _appContext.SaveChanges();
            }
                return estadioEncontrado;
            }
            return null;
        }
    }
}