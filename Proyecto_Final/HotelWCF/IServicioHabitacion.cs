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
        public int IdHabitacion { get; set; }
        public int IdSede { get; set; }
        public byte IdEstado { get; set; }
        public string DescripcionEstado { get; set; }
        public byte IdTipo { get; set; }
        public string DescripcionTipo { get; set; }
        public int Piso { get; set; }
        public double Precio { get; set; }
        public Boolean FechaEspecial { get; set; }
        public string Descripcion { get; set; }
    }
}
