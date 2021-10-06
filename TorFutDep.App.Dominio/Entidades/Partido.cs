using System;
namespace TorFutDep.App.Dominio
{
    public class Partido
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public Equipo Equipo_Visitante { get; set; }
        public int Marcador_Inicial_Visitante { get; set; }
        public Equipo Equipo_Local { get; set; }
        public int Marcador_Inicial_Local { get; set; }
        public string Marcador_Final { get; set; }
        public Estadio N_Estadio { get; set; }
        public Arbitro N_Arbitro { get; set; }
        public System.Collections.Generic.List<Novedad> Novedades { get; set; }
    }
}