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
        ReservaBL objReservaBL = new ReservaBL();
        private Cliente objClienteT;
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
            if (objClienteT == null)
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
            objClienteT = frmBusqueda.objClienteT;
            if (objClienteT != null)
            {
                lblNombres.Text = objClienteT.Apellido_Paterno + " " + objClienteT.Apellido_Materno + " " + objClienteT.Nombres;
                lblDocumento.Text = objClienteT.NroDocumento;
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
                //DB_test
                Reserva objReserva = new Reserva();
                objReserva.Fecha_Inicio_Reserva = dtpInicio.Value;
                objReserva.Fecha_Fin_Reserva = dtpFin.Value;
                objReserva.id_Cliente = objClienteT.id_Cliente;
                objReserva.id_Estado_Reserva = 1;
                objReserva.id_Habitacion = Convert.ToInt16(dgvDisponible.CurrentRow.Cells["IdHabitacion"].Value);
                short retornoTest = objReservaBL.InsertarReserva(objReserva);
                ReservaBE objReservaBE = new ReservaBE();
                objReservaBE.FechaInicioReserva = dtpInicio.Value;
                objReservaBE.FechaFinReserva = dtpFin.Value;
                objReservaBE.IdCliente = 807;
                objReservaBE.IdEstadoReserva = 1;
                objReservaBE.IdHabitacion = Convert.ToInt16(dgvDisponible.CurrentRow.Cells["IdHabitacion"].Value);
                objReservaBE.Agencia = true;
                objReservaBE.ApellidoPaterno = objClienteT.Apellido_Paterno;
                objReservaBE.ApellidoMaterno = objClienteT.Apellido_Materno;
                objReservaBE.Nombres = objClienteT.Nombres;
                objReservaBE.NroDocumento = objClienteT.NroDocumento;
                objReservaBE.idReservaAuxiliar = retornoTest;
                Boolean retornoServicio = objServicioReserva.InsertarReserva(objReservaBE);
                if (retornoTest!=0 || retornoServicio)
                {
                    MessageBox.Show("Se grabó con exito la reserva");
                    BuscarHabitacionLibre();
                    objClienteT = null;
                    lblNombres.Text = "";
                    lblDocumento.Text = "";
                }
                else
                {
                    MessageBox.Show("Error al registrar reserva");
                }
            }
        }

        private void dgvDisponible_SelectionChanged(object sender, EventArgs e)
        {
            HabitacionBE objHabitacionBE = new HabitacionBE();
            int idHabitacion = Convert.ToInt16(dgvDisponible.CurrentRow.Cells["IdHabitacion"].Value);
            if (idHabitacion!=0)
            {
                objHabitacionBE = objServicioHabitacion.DevuelveHabitacion(idHabitacion);
                TimeSpan dias = dtpFin.Value.Date - dtpInicio.Value.Date;
                lblTotal.Text = (objHabitacionBE.Precio * dias.Days).ToString("####0.00");
            }
            else
            {
                lblTotal.Text = "0.00";
            }
        }
    }
}
