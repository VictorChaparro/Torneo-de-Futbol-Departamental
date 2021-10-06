namespace TorFutDep.App.Dominio
{
    public class Desempeño_Equipo
    {
        public int Id { get; set; }
        public Equipo N_Equipo { get; set; }
        public int Cantidad_de_Partidos_Jugados { get; set; }
        public int Cantidad_de_Partidos_Ganados { get; set; }
        public int Cantidad_de_Partidos_Empatados { get; set; }
        public int Goles_A_Favor { get; set; }
        public int Goles_En_Contra { get; set; }
        public int Puntos { get; set; }
    }
}