using CapaAccesoServicios;
using CapaAccesoServicios.ProxyCliente;
using CapaAccesoServicios.ProxyHabitacion;
using CapaAccesoServicios.ProxyReserva;
using CapaAccesoServicios.ProxyUbigeo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEscritorio
{
    public partial class frmReserva : Form
    {
        ServicioHabitacion objServicioHabitacion = new ServicioHabitacion();
        ServiciosUbigeo objServicioUbigeo = new ServiciosUbigeo();
        ServiciosReserva objServicioReserva = new ServiciosReserva();
        private ClienteBE objClienteBE;
        public frmReserva()
        {
            InitializeComponent();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            cargaInicial();
        }
        private void cargaInicial()
        {
            cboSucursal.DataSource = objServicioHabitacion.ListarSede();
            cboSucursal.ValueMember = "idSede";
            cboSucursal.DisplayMember = "Nombre";
            llenarDireccion();
        }
        private void llenarDireccion()
        {
            SedeBE objSedeBE = (SedeBE)cboSucursal.SelectedItem;
            lblDIreccion.Text = objSedeBE.Direccion;
        }

        private Boolean validar()
        {
            if (objClienteBE == null)
            {
                MessageBox.Show("Por favor Selecciona Cliente");
                return false;
            }
            if (dgvDisponible.Rows.Count == 0)
            {
                MessageBox.Show("Tiene existir habitaciones disponibles");
                return false;
            }
            if (dgvDisponible.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una habitación");
                return false;
            }
            return true;
        }

        private void BuscarHabitacionLibre()
        {
            dgvDisponible.DataSource = objServicioHabitacion.ListarHabitacionesLibres(Convert.ToByte(cboSucursal.SelectedValue), dtpInicio.Value, dtpFin.Value);
        }

        private void cboSucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            llenarDireccion();
        }

        private void btnBuscarBusqueda_Click(object sender, EventArgs e)
        {
            BuscarHabitacionLibre();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmBusqueda = new frmCliente();
            frmBusqueda.ShowDialog();
            objClienteBE = frmBusqueda.objClienteBE;
            if (objClienteBE !=null)
            {
                lblNombres.Text = objClienteBE.ApellidoPaterno + " " + objClienteBE.ApellidoMaterno + " " + objClienteBE.Nombres;
                lblDocumento.Text = objClienteBE.NroDocumento;
            }
            else
            {
                lblNombres.Text = "";
                lblDocumento.Text = "";
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                ReservaBE objReservaBE = new ReservaBE();
                objReservaBE.FechaInicioReserva = dtpInicio.Value;
                objReservaBE.FechaFinReserva = dtpFin.Value;
                objReservaBE.IdCliente = objClienteBE.IdCliente;
                objReservaBE.IdEstadoReserva = 1;
                objReservaBE.IdHabitacion = Convert.ToInt16(dgvDisponible.CurrentRow.Cells["IdHabitacion"].Value);
                Boolean retorno = objServicioReserva.InsertarReserva(objReservaBE);
                if (retorno)
                {
                    MessageBox.Show("Se grabó con exito la reserva");
                    BuscarHabitacionLibre();
                    objClienteBE = null;
                    lblNombres.Text = "";
                    lblDocumento.Text = "";
                }
                else
                {
                    MessageBox.Show("Error al registrar reserva");
                }
            }
        }
    }
}
