using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoServicios
{
    public class ServicioHabitacion
    {
        ProxyHabitacion.ServicioHabitacionClient objServicioHabitacion = new ProxyHabitacion.ServicioHabitacionClient();
        public List<ProxyHabitacion.HabitacionBE> ListarHabitacionPorFecha(byte IdSede, DateTime FechaInicio, DateTime FechaFin)
        {
            return objServicioHabitacion.ListarHabitacionPorFecha(IdSede,FechaInicio,FechaFin);
        }
        public List<ProxyHabitacion.HabitacionBE> ListarPrecioHabitacionesPorSede(byte IdSede)
        {
            return objServicioHabitacion.ListarPrecioHabitacionesPorSede(IdSede);
        }
        public List<ProxyHabitacion.HabitacionBE> ListarHabitacionesLibres(byte IdSede, DateTime FechaInicio, DateTime FechaFin)
        {
            return objServicioHabitacion.ListarHabitacionesLibres(IdSede, FechaInicio, FechaFin);
        }
        public List<ProxyHabitacion.SedeBE> ListarSede()
        {
            return objServicioHabitacion.ListarSede();
        }
        public ProxyHabitacion.HabitacionBE DevuelveHabitacion(int idHabitacion)
        {
            return objServicioHabitacion.DevuelveHabitacion(idHabitacion);
        }
    }
}
