using CapaAccesoServicios;
using CapaAccesoServicios.ProxyHabitacion;
using CapaAccesoServicios.ProxyReserva;
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
    public partial class frmReservaPago : Form
    {

        ReservaBL objReservaBL = new ReservaBL();
        ServicioHabitacion objServicioHabitacion= new ServicioHabitacion();
        ServiciosReserva objServicioReserva = new ServiciosReserva();
        public frmReservaPago()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClienteBL objClienteBL = new ClienteBL();
            Cliente cliente = objClienteBL.DevuelveClienteDNI(txtNroDocumento.Text);
            lblNomCliente.Text = "";
            if (cliente != null)
            {
                lblNomCliente.Text = cliente.Apellido_Paterno + " " + cliente.Apellido_Materno + " " + cliente.Nombres;
            }
            List<Reserva> objListaReserva = new List<Reserva>();
            objListaReserva = objReservaBL.ListaReservaPendienteCliente(cliente.id_Cliente);

            dataGridView1.Rows.Clear();
            foreach (var item in objListaReserva)
            {
                TimeSpan dias = item.Fecha_Fin_Reserva - item.Fecha_Inicio_Reserva;
                HabitacionBE objHabitacion = objServicioHabitacion.DevuelveHabitacion(item.id_Habitacion);
                double precio = objHabitacion.Precio * dias.Days;
                string[] fila = { item.id_Reserva.ToString(), item.id_Habitacion.ToString(), item.Fecha_Registro.Date.ToString(), item.Fecha_Inicio_Reserva.Date.ToString(), item.Fecha_Fin_Reserva.Date.ToString(), precio.ToString()};
                dataGridView1.Rows.Add(fila);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            short idReserva = Convert.ToInt16(dataGridView1.CurrentRow.Cells["id_Reserva"].Value);
            Reserva objReserva = new Reserva();
            objReserva = objReservaBL.DevuelveReserva(idReserva);
            Boolean retornoTest = objReservaBL.PagarReserva(objReserva);

            ReservaBE objReservaBE = objServicioReserva.DevuelveReservaIdAuxiliar(idReserva);
            objReservaBE.IdEstadoReserva = 2;
            Boolean retornoServicio = objServicioReserva.ActualizarReserva(objReservaBE);
            if (retornoTest!=false || retornoServicio!=false)
            {
                MessageBox.Show("Reserva Pagada");
                lblNomCliente.Text = "";
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("No se pagó la reserva");
            }
        }
    }
}
