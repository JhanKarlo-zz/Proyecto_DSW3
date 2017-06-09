using System;
using System.Collections.Generic;
using System.Data;
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

        [OperationContract]
        List<ReservaBE> ListarReservaFechaEstado(DateTime FechaInicio,DateTime FechaFinal, byte? idEstadoReserva);
    }
    [DataContract]
    [Serializable]
    public class ReservaBE
    {
        [DataMember]
        public short IdReserva { get; set; }
        [DataMember]
        public int IdCliente { get; set; }
        [DataMember]
        public short IdHabitacion { get; set; }
        [DataMember]
        public byte IdEstadoReserva { get; set; }
        [DataMember]
        public DateTime FechaRegistro { get; set; }
        [DataMember]
        public DateTime FechaInicioReserva { get; set; }
        [DataMember]
        public DateTime FechaFinReserva { get; set; }
        [DataMember]
        public DateTime? FechaSalida { get; set; }
        [DataMember]
        public DateTime? FechaIngreso { get; set; }
    }
}
