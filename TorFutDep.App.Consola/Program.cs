using System;
using TorFutDep.App.Dominio;
using TorFutDep.App.Persistencia;

namespace TorFutDep.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //DeleteDirector_Tecnico();
            //AddMunicipio();
            //AddDirector_Tecnico();
            //AddEquipo();
            //AsignarDirector_Tecnico();
            //AddJugador();
            //AddArbitro();
            //AddEstadio();
            //AsignarMunicipio();
            //AddPartido();
            //AddDesempeño_Equipo();
            //AsignarArbitro();
            //AsignarEstadio();
            //AsignarEquipo();
        }
        private static IRepositorioJugador _repojugador = new RepositorioJugador();
        private static void AddJugador()
        {
            var jugador = new Jugador
            {
                Nombre_Jugador = "Oscar David Calixto Perez",
                Tipos_Posiciones = Tipo_Posicion.Defensa,
            };
            _repojugador.AddJugador(jugador);
        }
        private static IRepositorioEquipo _repoequipo = new RepositorioEquipo();
        private static void AddEquipo()
        {
            var equipo = new Equipo
            {
                Nombre_Equipo = "Barcelonians",
            };
            _repoequipo.AddEquipo(equipo);
        }
        private static IRepositorioMunicipio _repomunicipio = new RepositorioMunicipio();
        private static void AddMunicipio()
        {
            var municipio = new Municipio
            {
                Nombre_Municipio = "Villavicencio",
            };
            _repomunicipio.AddMunicipio(municipio);
        }
        private static IRepositorioDirector_Tecnico _repodirector_tecnico = new RepositorioDirector_Tecnico();
        private static void AddDirector_Tecnico()
        {
            var director_tecnico = new Director_Tecnico
            {
                Nombre_Director_Tecnico = "Laura Sofia Barreto Perez",
                Documento = "9121313",
                Telefono= "35345323",
            };
            _repodirector_tecnico.AddDirector_Tecnico(director_tecnico);
        }
        private static IRepositorioEstadio _repoestadio = new RepositorioEstadio();
        private static void AddEstadio()
        {
            var estadio = new Estadio
            {
                Nombre_Estadio = "Las Atalayas",
                Direccion = "Calle 40 #22-12",
            };
            _repoestadio.AddEstadio(estadio);
        }
        private static IRepositorioArbitro _repoarbitro = new RepositorioArbitro();
        private static void AddArbitro()
        {
            var arbitro = new Arbitro
            {
                Nombre_Arbitro = "Carlos Andres Pedraza",
                Documento = "43425",
                Telefono = "2313414",
            };
            _repoarbitro.AddArbitro(arbitro);
        }
        private static IRepositorioDesempeño_Equipo _repodesempeño_equipo = new RepositorioDesempeño_Equipo();
        private static void AddDesempeño_Equipo()
        {
            var desempeño_equipo = new Desempeño_Equipo
            {
                Cantidad_de_Partidos_Jugados = 22,
                Cantidad_de_Partidos_Ganados = 10,
                Cantidad_de_Partidos_Empatados = 7,
                Goles_A_Favor = 17,
                Goles_En_Contra = 18,
                Puntos = 37,
            };
            _repodesempeño_equipo.AddDesempeño_Equipo(desempeño_equipo);
        }
        private static IRepositorioPartido _repopartido = new RepositorioPartido();
        private static void AddPartido()
        {
            var partido = new Partido
            {
                FechaHora = new DateTime(2020, 05, 22, 2, 0, 0),
                Marcador_Inicial_Visitante = 0,
                Marcador_Inicial_Local = 0,
                Marcador_Final = "EqVi 3 - EqLo 2",
            };
            _repopartido.AddPartido(partido);
        }
        private static IRepositorioNovedad _reponovedad = new RepositorioNovedad();
        private static void AddNovedad()
        {
            var novedad = new Novedad
            {
                FechaHora = new DateTime(2020, 05, 22, 2, 0, 0),
                N_Tipo_Novedad = N_Tipo_Novedad.Gol,
            };
            _reponovedad.AddNovedad(novedad);
        }
        private static void AsignarDirector_Tecnico()
        {
            var director_tecnico = _repoequipo.AsignarDirector_Tecnico(2,1);
            Console.WriteLine(director_tecnico.Nombre_Director_Tecnico);
        }
        private static void AsignarMunicipio()
        {
            var municipio = _repoestadio.AsignarMunicipio(2,1);
            Console.WriteLine(municipio.Nombre_Municipio);
        }
        private static void AsignarEquipo()
        {
            var equipo = _repodesempeño_equipo.AsignarEquipo(2,1);
            Console.WriteLine(equipo.Nombre_Equipo);
        }
        private static void AsignarEstadio()
        {
            var estadio = _repopartido.AsignarEstadio(1,2);
            Console.WriteLine(estadio.Nombre_Estadio);
        }
        private static void AsignarArbitro()
        {
            var arbitro = _repopartido.AsignarArbitro(1,1);
            Console.WriteLine(arbitro.Nombre_Arbitro);
        }
        private static void AsignarJugador()
        {
            var jugador = _reponovedad.AsignarJugador(1,1);
            Console.WriteLine(jugador.Nombre_Jugador);
        }
        private static void AsignarPartido()
        {
            var partido = _reponovedad.AsignarPartido(1,1);
            Console.WriteLine("Partido Agregado");
        }
        private static void DeleteDirector_Tecnico()
        {
            _repodirector_tecnico.DeleteDirector_Tecnico(2);
        }
    }
}
