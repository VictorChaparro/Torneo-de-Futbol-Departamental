using System.Collections.Generic;
using System.Linq;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public class RepositorioEstadio : IRepositorioEstadio
    {
        private readonly AppContext _appContext;
        /// <param name="appContext"></param>//
        public RepositorioEstadio(AppContext appContext)
        {
            _appContext=appContext;
        }

        Estadio IRepositorioEstadio.AddEstadio(Estadio estadio)
        {
            var estadioAdicionado= _appContext.Estadios.Add(estadio);
            _appContext.SaveChanges();
            return estadioAdicionado.Entity;
        }
        void IRepositorioEstadio.DeleteEstadio(int idEstadio)
        {
            var estadioEncontrado=_appContext.Estadios.Find(idEstadio);
            if(estadioEncontrado==null)
                return;
            _appContext.Estadios.Remove(estadioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Estadio> IRepositorioEstadio.GetAllEstadios()
        {
            return _appContext.Estadios;
        }
        Estadio IRepositorioEstadio.GetEstadio(int idEstadio)
        {
            return _appContext.Estadios.Find(idEstadio);
        }
        Estadio IRepositorioEstadio.UpdateEstadio(Estadio estadio)
        {
            var estadioEncontrado=_appContext.Estadios.Find(estadio.Id);
            if (estadioEncontrado!=null)
            {
                estadioEncontrado.Nombre_Estadio=estadio.Nombre_Estadio;
                estadioEncontrado.Direccion =estadio.Direccion;

                _appContext.SaveChanges();
            }
            return estadioEncontrado;
        }
        Municipio IRepositorioEstadio.AsignarMunicipio(int idEstadio, int idMunicipio)
        { 
            var estadioEncontrado = _appContext.Estadios.Find(idEstadio);
            if (estadioEncontrado != null)
            {   
            var municipioEncontrado = _appContext.Municipios.Find(idMunicipio);
            if (municipioEncontrado != null)
            { 
                estadioEncontrado.N_Municipio = municipioEncontrado;
                _appContext.SaveChanges();
            }
                return municipioEncontrado;
            }
            return null;
        }
    }
}