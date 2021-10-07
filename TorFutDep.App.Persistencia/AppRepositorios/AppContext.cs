using Microsoft.EntityFrameworkCore;
using TorFutDep.App.Dominio;
namespace TorFutDep.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Arbitro> Arbitros { get; set; }
        public DbSet<Director_Tecnico> Directores_Tecnicos { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Estadio> Estadios { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Novedad> Novedades { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Desempeño_Equipo> Desempeño_Equipos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TorFutDepartamentalData");
            }
        }
    }
}