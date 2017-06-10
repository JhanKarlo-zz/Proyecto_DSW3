using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class frmConcurrenciaClientes : System.Web.UI.Page
    {
        ProxyCliente.ServicioClienteClient objServicioCliente = new ProxyCliente.ServicioClienteClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvClientes.DataSource = objServicioCliente.FrecuenciaClientes();
            gvClientes.DataBind();
        }
    }
}