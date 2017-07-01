using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoServicios
{
    public class ServiciosReserva
    {
        ProxyReserva.ServicioReservaClient objServicioReserva = new ProxyReserva.ServicioReservaClient();
        public Boolean InsertarReserva(ProxyReserva.ReservaBE objReserva)
        {
            return objServicioReserva.InsertarReserva(objReserva);
        }
        public Boolean ActualizarReserva(ProxyReserva.ReservaBE objReserva)
        {
            return objServicioReserva.ActualizarReserva(objReserva);
        }
        public List<ProxyReserva.ReservaBE> DevuelveReservasCliente(byte IdCliente)
        {
            return objServicioReserva.DevuelveReservasCliente(IdCliente);
        }
        public ProxyReserva.ReservaBE DevuelveReservaIdAuxiliar(short idAux)
        {
            return objServicioReserva.DevuelveReservaIdAuxiliar(idAux);
        }
    }
}
