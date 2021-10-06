using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorFutDep.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arbitros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Arbitro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directores_Tecnicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Director_Tecnico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directores_Tecnicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Equipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_MunicipioId = table.Column<int>(type: "int", nullable: true),
                    N_Director_TecnicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipos_Directores_Tecnicos_N_Director_TecnicoId",
                        column: x => x.N_Director_TecnicoId,
                        principalTable: "Directores_Tecnicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Municipios_N_MunicipioId",
                        column: x => x.N_MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Estadio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_MunicipioId = table.Column<int>(type: "int", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estadios_Municipios_N_MunicipioId",
                        column: x => x.N_MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Desempeño_Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    N_EquipoId = table.Column<int>(type: "int", nullable: true),
                    Cantidad_de_Partidos_Jugados = table.Column<int>(type: "int", nullable: false),
                    Cantidad_de_Partidos_Ganados = table.Column<int>(type: "int", nullable: false),
                    Cantidad_de_Partidos_Empatados = table.Column<int>(type: "int", nullable: false),
                    Goles_A_Favor = table.Column<int>(type: "int", nullable: false),
                    Goles_En_Contra = table.Column<int>(type: "int", nullable: false),
                    Puntos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desempeño_Equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Desempeño_Equipos_Equipos_N_EquipoId",
                        column: x => x.N_EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Jugador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipos_Posiciones = table.Column<int>(type: "int", nullable: false),
                    N_EquipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jugadores_Equipos_N_EquipoId",
                        column: x => x.N_EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Equipo_VisitanteId = table.Column<int>(type: "int", nullable: true),
                    Marcador_Inicial_Visitante = table.Column<int>(type: "int", nullable: false),
                    Equipo_LocalId = table.Column<int>(type: "int", nullable: true),
                    Marcador_Inicial_Local = table.Column<int>(type: "int", nullable: false),
                    Marcador_Final = table.Column<int>(type: "int", nullable: false),
                    N_EstadioId = table.Column<int>(type: "int", nullable: true),
                    N_ArbitroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partidos_Arbitros_N_ArbitroId",
                        column: x => x.N_ArbitroId,
                        principalTable: "Arbitros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Equipos_Equipo_LocalId",
                        column: x => x.Equipo_LocalId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Equipos_Equipo_VisitanteId",
                        column: x => x.Equipo_VisitanteId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Estadios_N_EstadioId",
                        column: x => x.N_EstadioId,
                        principalTable: "Estadios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Novedades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    N_EquipoId = table.Column<int>(type: "int", nullable: true),
                    N_JugadorId = table.Column<int>(type: "int", nullable: true),
                    N_EstadioId = table.Column<int>(type: "int", nullable: true),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    N_Tipo_Novedad = table.Column<int>(type: "int", nullable: false),
                    PartidoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novedades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Novedades_Equipos_N_EquipoId",
                        column: x => x.N_EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Novedades_Estadios_N_EstadioId",
                        column: x => x.N_EstadioId,
                        principalTable: "Estadios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Novedades_Jugadores_N_JugadorId",
                        column: x => x.N_JugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Novedades_Partidos_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Desempeño_Equipos_N_EquipoId",
                table: "Desempeño_Equipos",
                column: "N_EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_N_Director_TecnicoId",
                table: "Equipos",
                column: "N_Director_TecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_N_MunicipioId",
                table: "Equipos",
                column: "N_MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_N_MunicipioId",
                table: "Estadios",
                column: "N_MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_N_EquipoId",
                table: "Jugadores",
                column: "N_EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Novedades_N_EquipoId",
                table: "Novedades",
                column: "N_EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Novedades_N_EstadioId",
                table: "Novedades",
                column: "N_EstadioId");

            migrationBuilder.CreateIndex(
                name: "IX_Novedades_N_JugadorId",
                table: "Novedades",
                column: "N_JugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Novedades_PartidoId",
                table: "Novedades",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_Equipo_LocalId",
                table: "Partidos",
                column: "Equipo_LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_Equipo_VisitanteId",
                table: "Partidos",
                column: "Equipo_VisitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_N_ArbitroId",
                table: "Partidos",
                column: "N_ArbitroId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_N_EstadioId",
                table: "Partidos",
                column: "N_EstadioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desempeño_Equipos");

            migrationBuilder.DropTable(
                name: "Novedades");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Arbitros");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
                name: "Directores_Tecnicos");

            migrationBuilder.DropTable(
                name: "Municipios");
        }
    }
}
