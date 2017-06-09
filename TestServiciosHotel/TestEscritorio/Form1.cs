using CapaAccesoServicios;
using CapaAccesoServicios.ProxyCliente;
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
    public partial class frmCliente : Form
    {
        ServiciosUbigeo objServicioUbigeo = new ServiciosUbigeo();
        ServiciosCliente objServicioCliente = new ServiciosCliente();
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Enlaza a lima por defecto
                Enlazar("15", "01", "01");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Enlazar(String strIdDepartamento, String strIdProvincia, String strIdDistrito)
        {
            EnlazarDepartamento(strIdDepartamento);
            EnlazarProvincia(strIdDepartamento, strIdProvincia);
            EnlazarDistrito(strIdDepartamento, strIdProvincia, strIdDistrito);
        }
        private void EnlazarDepartamento(String strIdDepartamento)
        {
            cboDepartamento.DataSource = objServicioUbigeo.ListarDepartamentos();
            cboDepartamento.ValueMember = "idDepartamento";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = strIdDepartamento;
        }
        private void EnlazarProvincia(String strIdDepartamento, String strIdProvincia)
        {
            cboProvincia.DataSource = objServicioUbigeo.ListarProvinciasDepartamento(strIdDepartamento);
            cboProvincia.ValueMember = "idProvincia";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = strIdProvincia;
        }
        private void EnlazarDistrito(String strIdDepartamento, String strIdProvincia, String strIdDistrito)
        {
            cboDistrito.DataSource = objServicioUbigeo.ListarDistritosProvincia(strIdDepartamento, strIdProvincia);
            cboDistrito.ValueMember = "idDistrito";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = strIdDistrito;
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EnlazarProvincia(cboDepartamento.SelectedValue.ToString(), "01");
            EnlazarDistrito(cboDepartamento.SelectedValue.ToString(),
                cboProvincia.SelectedValue.ToString(), "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EnlazarDistrito(cboDepartamento.SelectedValue.ToString(),
                cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtNroDocumento.Text != String.Empty)
            {
                if (txtNroDocumento.Text.Length >= 8)
                {
                    grbValidacion.Enabled = false;
                    grbDatos.Enabled = true;
                    var respuesta = objServicioCliente.DevuelveClientePorDNI(txtNroDocumento.Text);
                    if (respuesta == null)
                    {
                        MessageBox.Show("Cliente no existe, porfavor llenar los datos");
                        txtNombres.Enabled = true;
                        txtMaterno.Enabled = true;
                        txtPaterno.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cliente registrado");
                        txtNombres.Text = respuesta.Nombres;
                        txtPaterno.Text = respuesta.ApellidoPaterno;
                        txtMaterno.Text = respuesta.ApellidoMaterno;
                        txtDireccion.Text = respuesta.Direccion;
                        txtCorreo.Text = respuesta.Correo;
                        dtpFechaNacimiento.Value = Convert.ToDateTime(respuesta.FechaNacimiento);
                        var objUbigeo = objServicioUbigeo.DevuelveUbigeo(respuesta.IdUbigeo);
                        Enlazar(objUbigeo.idDepartamento, objUbigeo.idProvincia, objUbigeo.idDistrito);
                        txtTelfCasa.Text = respuesta.TelefonoCasa;
                        txtTelfCelular.Text = respuesta.TelefonoCelular;
                        txtNombres.Enabled = false;
                        txtMaterno.Enabled = false;
                        txtPaterno.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("El documento no puede tener menos de 8 digitos");
                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            Enlazar("15", "01", "01");
            txtNombres.Enabled = true;
            txtMaterno.Enabled = true;
            txtPaterno.Enabled = true;
            grbValidacion.Enabled = true;
            grbDatos.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            ClienteBE objClienteBE = new ClienteBE();
            objClienteBE.ApellidoMaterno = txtMaterno.Text;
            objClienteBE.ApellidoPaterno = txtPaterno.Text;
            objClienteBE.ApellidoMaterno = txtMaterno.Text;
            objClienteBE.Nombres = txtNombres.Text;
            objClienteBE.NroDocumento = txtNroDocumento.Text;
            objClienteBE.Correo = txtCorreo.Text;
            objClienteBE.Direccion = txtDireccion.Text;
            objClienteBE.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Value.Date);
            objClienteBE.IdUbigeo = cboDepartamento.SelectedValue.ToString() + "" + cboProvincia.SelectedValue.ToString() + "" + cboDistrito.SelectedValue.ToString();
            objClienteBE.IdTipoCliente = 1;
            objClienteBE.TelefonoCasa = txtTelfCasa.Text;
            objClienteBE.TelefonoCelular = txtTelfCelular.Text;
            Boolean retorno = false;
            if (txtNombres.Enabled == true)
            {
                retorno = objServicioCliente.InsertarCliente(objClienteBE);
            }
            else
            {
                var cliente = objServicioCliente.DevuelveClientePorDNI(txtNroDocumento.Text);
                objClienteBE.IdCliente = cliente.IdCliente;
                retorno = objServicioCliente.ActualizarCliente(objClienteBE);
            }
            if (retorno == true)
            {
                MessageBox.Show("Exito al grabar");
                this.Close();
            }
        }
    }
}
