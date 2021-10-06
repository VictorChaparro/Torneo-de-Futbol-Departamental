namespace TorFutDep.App.Dominio
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre_Jugador { get; set; }
        public Tipo_Posicion Tipos_Posiciones {get; set; }
        public Equipo N_Equipo { get; set; }
    }
}