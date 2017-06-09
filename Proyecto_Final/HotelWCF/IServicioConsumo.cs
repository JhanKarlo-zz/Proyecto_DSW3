using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioConsumo" in both code and config file together.
    [ServiceContract]
    public interface IServicioConsumo
    {
        [OperationContract]
        List<ConsumoBE> ListarConsumoReserva(short IdReserva);

        [OperationContract]
        Boolean InsertarConsumoReserva(ConsumoBE objConsumoBE);

        [OperationContract]
        Boolean ActualizarConsumoReserva(ConsumoBE objConsumoBE);
    }
    [DataContract]
    [Serializable]
    public class ConsumoBE
    {
        [DataMember]
        public short IdConsumo { get; set; }
        [DataMember]
        public byte IdEstadoConsumo { get; set; }
        [DataMember]
        public short IdProducto { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
        [DataMember]
        public short Cantidad { get; set; }
        [DataMember]
        public short IdReserva { get; set; }
        [DataMember]
        public string DescripcionEstado { get; set; }

        public string DevuelveDescripcionEstado(byte _idEstado)
        {
            switch (_idEstado)
                {
                    case 0:
                        return "PENDIENTE";

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
    }
}
