using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoServicios
{
    public class ServiciosCliente
    {
        ProxyCliente.ServicioClienteClient objServicioCliente = new ProxyCliente.ServicioClienteClient();
        public bool ActualizarCliente(ProxyCliente.ClienteBE objClienteBE)
        {
            return objServicioCliente.ActualizarCliente(objClienteBE);
        }
        public ProxyCliente.ClienteBE DevuelveClientePorDNI(string dni)
        {
            return objServicioCliente.DevuelveClientePorDNI(dni);
        }
        public bool InsertarCliente(ProxyCliente.ClienteBE objClienteBE)
        {
            return objServicioCliente.InsertarCliente(objClienteBE);
        }
    }
}
