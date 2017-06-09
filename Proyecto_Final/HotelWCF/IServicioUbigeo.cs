using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUbigeo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUbigeo
    {
        [OperationContract]
        List<UbigeoBE> ListarDepartamentos();
        [OperationContract]
        List<UbigeoBE> ListarProvinciasDepartamento(string idDepartamento);
        [OperationContract]
        List<UbigeoBE> ListarDistritosProvincia(string idDepartamento, string idProvincia);
        [OperationContract]
        UbigeoBE DevuelveUbigeo(string idUbigeo);
    }
    [DataContract]
    [Serializable]
    public class UbigeoBE
    {
        [DataMember]
        public string idUbigeo { get; set; }
        [DataMember]
        public string idDepartamento { get; set; }
        [DataMember]
        public string Departamento { get; set; }
        [DataMember]
        public string idProvincia { get; set; }
        [DataMember]
        public string Provincia { get; set; }
        [DataMember]
        public string idDistrito { get; set; }
        [DataMember]
        public string Distrito { get; set; }
        [DataMember]
        public string idContinente { get; set; }
        [DataMember]
        public string Continente { get; set; }
        [DataMember]
        public string idPais { get; set; }
        [DataMember]
        public string Pais { get; set; }
        [DataMember]
        public string idCiudad { get; set; }
        [DataMember]
        public string Ciudad { get; set; }
    }
}
