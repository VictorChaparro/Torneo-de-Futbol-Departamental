using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorFutDep.App.Dominio;
using TorFutDep.App.Persistencia;

namespace TorFutDep.App.Frontend.Pages.Directores_Tecnicos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDirector_Tecnico _repoDirector_tecnico;
        public IEnumerable<Director_Tecnico> directores_tecnicos { get; set; }
        public IndexModel(IRepositorioDirector_Tecnico repoDirector_tecnico)
        {
            _repoDirector_tecnico = repoDirector_tecnico;
        }
        public void OnGet()
        {
            directores_tecnicos = _repoDirector_tecnico.GetAllDirectores_Tecnicos();
        }
    }
}
