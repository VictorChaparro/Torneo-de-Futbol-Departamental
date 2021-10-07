using System.Collections.Generic;
using System.Linq;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        private readonly AppContext _appContext = new AppContext();
        
        Arbitro IRepositorioArbitro.AddArbitro(Arbitro arbitro)
        {
            var arbitroAdicionado= _appContext.Arbitros.Add(arbitro);
            _appContext.SaveChanges();
            return arbitroAdicionado.Entity;
        }
        void IRepositorioArbitro.DeleteArbitro(int idArbitro)
        {
            var arbitroEncontrado=_appContext.Arbitros.Find(idArbitro);
            if(arbitroEncontrado==null)
                return;
            _appContext.Arbitros.Remove(arbitroEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Arbitro> IRepositorioArbitro.GetAllArbitros()
        {
            return _appContext.Arbitros;
        }
        Arbitro IRepositorioArbitro.GetArbitro(int idArbitro)
        {
            return _appContext.Arbitros.Find(idArbitro);
        }
        Arbitro IRepositorioArbitro.UpdateArbitro(Arbitro arbitro)
        {
            var arbitroEncontrado=_appContext.Arbitros.Find(arbitro.Id);
            if (arbitroEncontrado!=null)
            {
                arbitroEncontrado.Nombre_Arbitro=arbitro.Nombre_Arbitro;

                _appContext.SaveChanges();
            }
            return arbitroEncontrado;
        }
    }
}