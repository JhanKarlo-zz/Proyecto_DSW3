using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoServicios
{
    public class ServiciosUbigeo
    {
        ProxyUbigeo.ServicioUbigeoClient objServicioUbigeo = new ProxyUbigeo.ServicioUbigeoClient();
        public List<ProxyUbigeo.UbigeoBE> ListarDepartamentos()
        {
            return objServicioUbigeo.ListarDepartamentos();
        }
        public List<ProxyUbigeo.UbigeoBE> ListarDistritosProvincia(string idDepartamento, string idProvincia)
        {
            return objServicioUbigeo.ListarDistritosProvincia(idDepartamento,idProvincia);
        }
        public List<ProxyUbigeo.UbigeoBE> ListarProvinciasDepartamento(string idDepartamento)
        {
            return objServicioUbigeo.ListarProvinciasDepartamento(idDepartamento);
        }
        public ProxyUbigeo.UbigeoBE DevuelveUbigeo(string idUbigeo)
        {
            return objServicioUbigeo.DevuelveUbigeo(idUbigeo);
        }
    }
}
