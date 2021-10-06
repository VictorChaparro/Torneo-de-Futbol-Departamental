namespace TorFutDep.App.Dominio
{
    public class Estadio
    {
        public int Id { get; set; }
        public string Nombre_Estadio { get; set; }
        public Municipio N_Municipio { get; set; }
        public string Direccion { get; set; }
    }
}