using System.Collections.Generic;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public interface IRepositorioArbitro
    {
        IEnumerable<Arbitro> GetAllArbitros();
        Arbitro AddArbitro(Arbitro arbitro);
        Arbitro UpdateArbitro(Arbitro arbitro);
        void DeleteArbitro(int idArbitro);
        Arbitro GetArbitro(int idArbitro);
    }
}