using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioHabitacion" in both code and config file together.
    [ServiceContract]
    public interface IServicioHabitacion
    {
        [OperationContract]
        List<HabitacionBE> ListarHabitacionPorFecha(byte IdSede, DateTime FechaInicio, DateTime FechaFin);
        [OperationContract]
        List<HabitacionBE> ListarHabitacionesLibres(byte IdSede, DateTime FechaInicio, DateTime FechaFin);
        [OperationContract]
        List<HabitacionBE> ListarPrecioHabitacionesPorSede(byte IdSede);
    }
    public class HabitacionBE
    {
        [DataMember]
        public int IdHabitacion { get; set; }
        [DataMember]
        public int IdSede { get; set; }
        [DataMember]
        public byte IdEstado { get; set; }
        [DataMember]
        public string DescripcionEstado { get; set; }
        [DataMember]
        public byte IdTipo { get; set; }
        [DataMember]
        public string DescripcionTipo { get; set; }
        [DataMember]
        public int Piso { get; set; }
        [DataMember]
        public double Precio { get; set; }
        [DataMember]
        public Boolean FechaEspecial { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}
