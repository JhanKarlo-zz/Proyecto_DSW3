using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioCliente" in both code and config file together.
    [ServiceContract]
    public interface IServicioCliente
    {
        [OperationContract]
        ClienteBE DevuelveClientePorDNI(string dni);
        [OperationContract]
        Boolean InsertarCliente(ClienteBE objClienteBE);
        [OperationContract]
        Boolean ActualizarCliente(ClienteBE objClienteBE);
    }
    public class ClienteBE
    {
        [DataMember]
        public int IdCliente { get; set; }
        [DataMember]
        public string ApellidoPaterno { get; set; }
        [DataMember]
        public string ApellidoMaterno { get; set; }
        [DataMember]
        public string Nombres { get; set; }
        [DataMember]
        public DateTime FechaNacimiento { get; set; }
        [DataMember]
        public string NroDocumento { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public string TelefonoCasa { get; set; }
        [DataMember]
        public string TelefonoCelular { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string IdUbigeo { get; set; }
        [DataMember]
        public byte IdTipoCliente { get; set; }
    }
}
