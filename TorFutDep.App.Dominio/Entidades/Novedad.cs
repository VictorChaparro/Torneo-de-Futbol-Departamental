using System;
namespace TorFutDep.App.Dominio
{
    public class Novedad
    {
        public int Id { get; set; }
        public Equipo N_Equipo { get; set; }
        public Jugador N_Jugador { get; set; }
        public Partido N_Partido { get; set; }
        public DateTime FechaHora { get; set; }
        public Tipo_Novedad N_Tipo_Novedad { get; set; }
    }
}