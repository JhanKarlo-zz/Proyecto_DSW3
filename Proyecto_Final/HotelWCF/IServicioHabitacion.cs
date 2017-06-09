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
        [OperationContract]
        HabitacionBE DevuelveHabitacion(int idHabitacion);
        [OperationContract]
        List<SedeBE> ListarSede();
    }
    [DataContract]
    [Serializable]
    public class HabitacionBE
    {
        [DataMember]
        public int IdHabitacion { get; set; }
        [DataMember]
        public int IdSede { get; set; }
        [DataMember]
        public byte IdEstado { get; set; }
        [DataMember]
        public byte IdTipo { get; set; }
        [DataMember]
        public int Piso { get; set; }
        [DataMember]
        public double Precio { get; set; }
        [DataMember]
        public Boolean FechaEspecial { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string DescripcionEstado { get; set; }
        [DataMember]
        public string DescripcionTipo { get; set; }

        public string DevuelveDescripcionEstado(byte _idEstado)
        {
            switch (_idEstado)
                {
                    case 0:
                        return "LIBRE";

                    case 1:
                        return "RESERVADO";

                    case 2:
                        return "PAGADO";

                    case 3:
                        return "ANULADO";

                default:
                        return null;
            }
        }

        public string DevuelveDescripcionTipo(byte _idTipo)
        {
            switch (_idTipo)
            {
                case 1:
                    return "INDIVIDUAL";

                case 2:
                    return "HABITACION DOBLE";

                case 3:
                    return "HABITACION TRIPLE";

                case 4:
                    return "SUITE";

                default:
                    return null;
            }
        }
    }
    [DataContract]
    [Serializable]
    public class SedeBE
    {
        [DataMember]
        public byte idSede { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string idUbigeo { get; set; }
    }
}
