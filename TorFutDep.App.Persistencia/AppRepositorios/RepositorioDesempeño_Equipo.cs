using System.Collections.Generic;
using System.Linq;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public class RepositorioDesempeño_Equipo : IRepositorioDesempeño_Equipo
    {
        private readonly AppContext _appContext = new AppContext();

        Desempeño_Equipo IRepositorioDesempeño_Equipo.AddDesempeño_Equipo(Desempeño_Equipo desempeño_equipo)
        {
            var desempeño_equipoAdicionado= _appContext.Desempeño_Equipos.Add(desempeño_equipo);
            _appContext.SaveChanges();
            return desempeño_equipoAdicionado.Entity;
        }
        void IRepositorioDesempeño_Equipo.DeleteDesempeño_Equipo(int idDesempeño_Equipo)
        {
            var desempeño_equipoEncontrado=_appContext.Desempeño_Equipos.Find(idDesempeño_Equipo);
            if(desempeño_equipoEncontrado==null)
                return;
            _appContext.Desempeño_Equipos.Remove(desempeño_equipoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Desempeño_Equipo> IRepositorioDesempeño_Equipo.GetAllDesempeño_Equipos()
        {
            return _appContext.Desempeño_Equipos;
        }
        Desempeño_Equipo IRepositorioDesempeño_Equipo.GetDesempeño_Equipo(int idDesempeño_Equipo)
        {
            return _appContext.Desempeño_Equipos.Find(idDesempeño_Equipo);
        }
        Desempeño_Equipo IRepositorioDesempeño_Equipo.UpdateDesempeño_Equipo(Desempeño_Equipo desempeño_equipo)
        {
            var desempeño_equipoEncontrado=_appContext.Desempeño_Equipos.Find(desempeño_equipo.Id);
            if (desempeño_equipoEncontrado!=null)
            {
                desempeño_equipoEncontrado.Cantidad_de_Partidos_Jugados=desempeño_equipo.Cantidad_de_Partidos_Jugados;
                desempeño_equipoEncontrado.Cantidad_de_Partidos_Ganados=desempeño_equipo.Cantidad_de_Partidos_Ganados;
                desempeño_equipoEncontrado.Cantidad_de_Partidos_Empatados=desempeño_equipo.Cantidad_de_Partidos_Empatados;
                desempeño_equipoEncontrado.Goles_A_Favor=desempeño_equipo.Goles_A_Favor;
                desempeño_equipoEncontrado.Goles_En_Contra=desempeño_equipo.Goles_En_Contra;
                desempeño_equipoEncontrado.Puntos=desempeño_equipo.Puntos;

                _appContext.SaveChanges();
            }
            return desempeño_equipoEncontrado;
        }
        Equipo IRepositorioDesempeño_Equipo.AsignarEquipo(int idDesempeño_Equipo, int idEquipo)
        { 
            var desempeño_equipoEncontrado = _appContext.Desempeño_Equipos.Find(idDesempeño_Equipo);
            if (desempeño_equipoEncontrado != null)
            {   
            var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
            if (equipoEncontrado != null)
            { 
                desempeño_equipoEncontrado.N_Equipo = equipoEncontrado;
                _appContext.SaveChanges();
            }
                return equipoEncontrado;
            }
            return null;
        }
    }
}