using System;
using System.ComponentModel.DataAnnotations;
namespace TorFutDep.App.Dominio
{
    public class Director_Tecnico
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "¡El Nombre es Obligatorio!")]
        [Display(Name = "Nombre Completo")]
        public string Nombre_Director_Tecnico { get; set; }
        [StringLength(10)]
        public string Documento { get; set; }
        [StringLength(10)]
        public string Telefono { get; set; }
    }
}