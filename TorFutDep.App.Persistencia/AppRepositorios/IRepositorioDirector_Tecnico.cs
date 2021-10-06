using System.Collections.Generic;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public interface IRepositorioDirector_Tecnico
    {
        IEnumerable<Director_Tecnico> GetAllDirectores_Tecnicos();
        Director_Tecnico AddDirector_Tecnico(Director_Tecnico director_tecnico);
        Director_Tecnico UpdateDirector_Tecnico(Director_Tecnico director_tecnico);
        void DeleteDirector_Tecnico(int idDirector_Tecnico);
        Director_Tecnico GetDirector_Tecnico(int idDirector_Tecnico);
    }
}