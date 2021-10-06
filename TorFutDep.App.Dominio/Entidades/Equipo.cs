namespace TorFutDep.App.Dominio
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre_Equipo { get; set; }
        /*La N en Municipio y Director_Técnico significa Nombre y lo mismo va para las otras que tengan la N*/
        public Municipio N_Municipio { get; set; }
        public Director_Tecnico N_Director_Tecnico { get; set; }
    }
}