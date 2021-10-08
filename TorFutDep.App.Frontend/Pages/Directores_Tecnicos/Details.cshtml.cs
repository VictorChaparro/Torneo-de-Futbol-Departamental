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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDirector_Tecnico _repoDirector_tecnico;
        public Director_Tecnico director_tecnico { get; set; }
        public DetailsModel(IRepositorioDirector_Tecnico repoDirector_tecnico)
        {
            _repoDirector_tecnico = repoDirector_tecnico;
        }
        public IActionResult OnGet(int id)
        {
            director_tecnico = _repoDirector_tecnico.GetDirector_Tecnico(id);
            if(director_tecnico == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}