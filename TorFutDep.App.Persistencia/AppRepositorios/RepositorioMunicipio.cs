using System.Collections.Generic;
using System.Linq;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {
        private readonly AppContext _appContext = new AppContext();
        Municipio IRepositorioMunicipio.AddMunicipio(Municipio municipio)
        {
            var municipioAdicionado= _appContext.Municipios.Add(municipio);
            _appContext.SaveChanges();
            return municipioAdicionado.Entity;
        }
        void IRepositorioMunicipio.DeleteMunicipio(int idMunicipio)
        {
            var municipioEncontrado=_appContext.Municipios.Find(idMunicipio);
            if(municipioEncontrado==null)
                return;
            _appContext.Municipios.Remove(municipioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Municipio> IRepositorioMunicipio.GetAllMunicipios()
        {
            return _appContext.Municipios;
        }
        Municipio IRepositorioMunicipio.GetMunicipio(int idMunicipio)
        {
            return _appContext.Municipios.Find(idMunicipio);
        }
        Municipio IRepositorioMunicipio.UpdateMunicipio(Municipio municipio)
        {
            var municipioEncontrado=_appContext.Municipios.Find(municipio.Id);
            if (municipioEncontrado!=null)
            {
                municipioEncontrado.Nombre_Municipio=municipio.Nombre_Municipio;

                _appContext.SaveChanges();
            }
            return municipioEncontrado;
        }
    }
}