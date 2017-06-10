using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class frmListarReservaFechaEstado : System.Web.UI.Page
    {
        ProxyReserva.ServicioReservaClient objServicioReserva = new ProxyReserva.ServicioReservaClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtInicio.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txtFin.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            byte? idEstado;
            if ("Todos" == cboEstado.SelectedValue)
            {
                idEstado = null;
            }
            else
            {
                idEstado = Convert.ToByte(cboEstado.SelectedValue);
            }
            gvReservas.DataSource = objServicioReserva.ListarReservaFechaEstado(Convert.ToDateTime(txtInicio.Text),Convert.ToDateTime(txtFin.Text),idEstado);
            gvReservas.DataBind();
        }
    }
}