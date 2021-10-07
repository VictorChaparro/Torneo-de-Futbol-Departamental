using System.Collections.Generic;
using System.Linq;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public class RepositorioDirector_Tecnico : IRepositorioDirector_Tecnico
    {
        private readonly AppContext _appContext = new AppContext();

        Director_Tecnico IRepositorioDirector_Tecnico.AddDirector_Tecnico(Director_Tecnico director_tecnico)
        {
            var director_tecnicoAdicionado= _appContext.Directores_Tecnicos.Add(director_tecnico);
            _appContext.SaveChanges();
            return director_tecnicoAdicionado.Entity;
        }
        void IRepositorioDirector_Tecnico.DeleteDirector_Tecnico(int idDirector_Tecnico)
        {
            var director_tecnicoEncontrado=_appContext.Directores_Tecnicos.Find(idDirector_Tecnico);
            if(director_tecnicoEncontrado==null)
                return;
            _appContext.Directores_Tecnicos.Remove(director_tecnicoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Director_Tecnico> IRepositorioDirector_Tecnico.GetAllDirectores_Tecnicos()
        {
            return _appContext.Directores_Tecnicos;
        }
        Director_Tecnico IRepositorioDirector_Tecnico.GetDirector_Tecnico(int idDirector_Tecnico)
        {
            return _appContext.Directores_Tecnicos.Find(idDirector_Tecnico);
        }
        Director_Tecnico IRepositorioDirector_Tecnico.UpdateDirector_Tecnico(Director_Tecnico director_tecnico)
        {
            var director_tecnicoEncontrado=_appContext.Directores_Tecnicos.Find(director_tecnico.Id);
            if (director_tecnicoEncontrado!=null)
            {
                director_tecnicoEncontrado.Nombre_Director_Tecnico=director_tecnico.Nombre_Director_Tecnico;
                director_tecnicoEncontrado.Documento=director_tecnico.Documento;
                director_tecnicoEncontrado.Telefono=director_tecnico.Telefono;

                _appContext.SaveChanges();
            }
            return director_tecnicoEncontrado;
        }
    }
}