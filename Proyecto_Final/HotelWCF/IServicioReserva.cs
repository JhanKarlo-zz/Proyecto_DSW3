using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioReserva" in both code and config file together.
    [ServiceContract]
    public interface IServicioReserva
    {
        [OperationContract]
        Boolean InsertarReserva(ReservaBE objReserva);

        [OperationContract]
        Boolean ActualizarReserva(ReservaBE objReserva);

        [OperationContract]
        List<ReservaBE> DevuelveReservasCliente(byte IdCliente);
    }
    public class ReservaBE
    {
        public short IdReserva { get; set; }
        public int IdCliente { get; set; }
        public short IdHabitacion { get; set; }
        public byte IdEstadoReserva { get; set; }
        public short? IdConsumo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaInicioReserva { get; set; }
        public DateTime FechaFinReserva { get; set; }
        public DateTime? FechaSalida { get; set; }
        public DateTime? FechaIngreso { get; set; }
    }
}
