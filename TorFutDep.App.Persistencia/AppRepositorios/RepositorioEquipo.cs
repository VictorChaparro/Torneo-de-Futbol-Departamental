using System.Collections.Generic;
using System.Linq;
using TorFutDep.App.Dominio;

namespace TorFutDep.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly AppContext _appContext;
        /// <param name="appContext"></param>//
        public RepositorioEquipo(AppContext appContext)
        {
            _appContext=appContext;
        }

        Equipo IRepositorioEquipo.AddEquipo(Equipo equipo)
        {
            var equipoAdicionado= _appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return equipoAdicionado.Entity;
        }
        void IRepositorioEquipo.DeleteEquipo(int idEquipo)
        {
            var equipoEncontrado=_appContext.Equipos.Find(idEquipo);
            if(equipoEncontrado==null)
                return;
            _appContext.Equipos.Remove(equipoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Equipo> IRepositorioEquipo.GetAllEquipos()
        {
            return _appContext.Equipos;
        }
        Equipo IRepositorioEquipo.GetEquipo(int idEquipo)
        {
            return _appContext.Equipos.Find(idEquipo);
        }
        Equipo IRepositorioEquipo.UpdateEquipo(Equipo equipo)
        {
            var equipoEncontrado=_appContext.Equipos.Find(equipo.Id);
            if (equipoEncontrado!=null)
            {
                equipoEncontrado.Nombre_Equipo=equipo.Nombre_Equipo;

                _appContext.SaveChanges();
            }
            return equipoEncontrado;
        }
        Director_Tecnico IRepositorioEquipo.AsignarDirector_Tecnico(int idEquipo, int idDirector_Tecnico)
        { 
            var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
            if (equipoEncontrado != null)
            {   
            var director_tecnicoEncontrado = _appContext.Directores_Tecnicos.Find(idDirector_Tecnico);
            if (director_tecnicoEncontrado != null)
            { 
                equipoEncontrado.N_Director_Tecnico = director_tecnicoEncontrado;
                _appContext.SaveChanges();
            }
                return director_tecnicoEncontrado;
            }
            return null;
        }
        Municipio IRepositorioEquipo.AsignarMunicipio(int idEquipo, int idMunicipio)
        { 
            var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
            if (equipoEncontrado != null)
            {   
            var municipioEncontrado = _appContext.Municipios.Find(idMunicipio);
            if (municipioEncontrado != null)
            { 
                equipoEncontrado.N_Municipio = municipioEncontrado;
                _appContext.SaveChanges();
            }
                return municipioEncontrado;
            }
            return null;
        }
    }
}