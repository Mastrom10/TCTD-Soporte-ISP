using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using SERV;

using System.Data;

namespace BLL
{
    public class TurnoBLL : GenericBLL<Turno>

    {
        public TurnoBLL()
        {
            dal = new TurnoDAL();
            permiso = TipoPermiso.CRUDTurno;
        }

        public class TurnosPivot {
            public DateTime Fecha { get; set; }
            public string franjaHoraria { get; set; }
            public int Disponibles { get; set; }
            public int Tomados { get; set; }
            public int Cancelados { get; set; }

        }
        public List<TurnosPivot> GetTurnosByFechaRange(DateTime FechaDesde, DateTime FechaHasta)
        {
            List<Turno> turnos =  ((TurnoDAL)dal).GetTurnosByFechaRange(FechaDesde.Date, FechaHasta.Date);
            DataTable dt = new DataTable();
            var query = turnos.GroupBy(t => new { t.fecha.Date, t.franjaHoraria, t.estadoTurno },
                (key, group) => new TurnosPivot
                {
                    Fecha = key.Date,
                    franjaHoraria = key.franjaHoraria.ToString(),
                    Disponibles = group.Count(t => t.estadoTurno == EstadoTurno.Disponible),
                    Tomados = group.Count(t => t.estadoTurno == EstadoTurno.Tomado),
                    Cancelados = group.Count(t => t.estadoTurno == EstadoTurno.Cancelado)
                });
            return query.ToList();

        }

        public List<TurnosPivot> GetTurnosProximaSemana()
        {
            //today 00hs
            DateTime hoy = DateTime.Today;
            // + 7 dias
            DateTime semana = hoy.AddDays(7);
            return GetTurnosByFechaRange(hoy, semana);
        }


        public List<Turno> GetTurnosDisponibles()
        {
            //today 00hs
            DateTime hoy = DateTime.Today;
            // +30 dias
            DateTime semana = hoy.AddDays(30);
            
            List<Turno> turnos = ((TurnoDAL)dal).GetTurnosByFechaRange(hoy.Date, semana.Date);
            return turnos.Where(t => t.estadoTurno == EstadoTurno.Disponible).ToList();
        }
        public int[] GetTurnosTomadosByFechayFranjaHoraria(DateTime fecha, FranjaHoraria franjaHoraria) {
            //fecha at 00hs
            List<Turno> turnos = ((TurnoDAL)dal).GetTurnosByFechaRange(fecha.Date, fecha.Date);
            int[] turnosTomados = new int[3];
            turnosTomados[0] = turnos.Count(t => t.estadoTurno == EstadoTurno.Tomado && t.franjaHoraria == franjaHoraria);
            turnosTomados[2] = turnos.Count(t => t.estadoTurno == EstadoTurno.Cancelado && t.franjaHoraria == franjaHoraria);
            turnosTomados[1] = turnos.Count(t => t.estadoTurno == EstadoTurno.Disponible && t.franjaHoraria == franjaHoraria);
            return turnosTomados;
        }

        public void SetTurnosDisponibles(DateTime fecha, FranjaHoraria franjaHoraria, int cantidad)
        {
            List<Turno> turnos = ((TurnoDAL)dal).GetTurnosByFechaRange(fecha.Date, fecha.Date);
            int turnosDisponibles = turnos.Count(t => t.estadoTurno == EstadoTurno.Disponible && t.franjaHoraria == franjaHoraria);
            if (turnosDisponibles < cantidad)
            {
                for (int i = turnosDisponibles; i < cantidad; i++)
                {
                    Turno turno = new Turno();
                    turno.estadoTurno = EstadoTurno.Disponible;
                    turno.fecha = fecha.Date;
                    turno.franjaHoraria = franjaHoraria;
                    dal.Create(turno);
                }
            }
            else if (turnosDisponibles > cantidad)
            {
                for (int i = turnosDisponibles; i > cantidad; i--)
                {
                    Turno turno = turnos.Where(t => t.estadoTurno == EstadoTurno.Disponible && t.franjaHoraria == franjaHoraria).First();
                    turnos.Remove(turno);
                    dal.Delete(turno);
                }
            }
        }
    }
}
