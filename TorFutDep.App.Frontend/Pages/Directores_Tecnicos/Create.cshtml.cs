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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDirector_Tecnico _repoDirector_tecnico;
        public Director_Tecnico director_tecnico { get; set; }
        public CreateModel(IRepositorioDirector_Tecnico repoDirector_tecnico)
        {
            _repoDirector_tecnico = repoDirector_tecnico;
        }
        public void OnGet()
        {
            director_tecnico = new Director_Tecnico();
        }
        public IActionResult OnPost(Director_Tecnico director_Tecnico)
        {
            if (ModelState.IsValid)
            {
                _repoDirector_tecnico.AddDirector_Tecnico(director_Tecnico);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
