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
        ClienteBL objClienteBL = new ClienteBL();
        public ClienteBE objClienteServBE { get; set; }
        public Cliente objClienteT { get; set; }
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
                    objClienteT = objClienteBL.DevuelveClienteDNI(txtNroDocumento.Text);
                    if (objClienteT == null)
                    {
                        MessageBox.Show("Cliente no existe, porfavor llenar los datos");
                        txtNombres.Enabled = true;
                        txtMaterno.Enabled = true;
                        txtPaterno.Enabled = true;
                    }
                    else
                    {
                        txtNombres.Text = objClienteT.Nombres;
                        txtPaterno.Text = objClienteT.Apellido_Paterno;
                        txtMaterno.Text = objClienteT.Apellido_Materno;
                        txtDireccion.Text = objClienteT.Direccion;
                        txtCorreo.Text = objClienteT.Correo;
                        var objUbigeo = objServicioUbigeo.DevuelveUbigeo(objClienteT.id_Ubigeo);
                        Enlazar(objUbigeo.idDepartamento, objUbigeo.idProvincia, objUbigeo.idDistrito);
                        txtTelfCelular.Text = objClienteT.Telefono;
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
            //Limpiar
            txtNombres.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            Enlazar("15", "01", "01");
            txtNombres.Enabled = true;
            txtMaterno.Enabled = true;
            txtPaterno.Enabled = true;
            grbValidacion.Enabled = true;
            grbDatos.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Boolean retorno = false;
            if (objClienteT == null)
            {
                objClienteT = new Cliente();
                objClienteT.Apellido_Materno = txtMaterno.Text;
                objClienteT.Apellido_Paterno = txtPaterno.Text;
                objClienteT.Nombres = txtMaterno.Text;
                objClienteT.Nombres = txtNombres.Text;
                objClienteT.NroDocumento = txtNroDocumento.Text;
                objClienteT.Correo = txtCorreo.Text;
                objClienteT.Direccion = txtDireccion.Text;
                objClienteT.id_Ubigeo = cboDepartamento.SelectedValue.ToString() + "" + cboProvincia.SelectedValue.ToString() + "" + cboDistrito.SelectedValue.ToString();
                objClienteT.Telefono = txtTelfCelular.Text;
            }

            if (txtNombres.Enabled == true)
            {
                retorno = objClienteBL.InsertarCliente(objClienteT);
            }
            else
            {
                retorno = objClienteBL.ActualizarCliente(objClienteT);
            }
            if (retorno == true)
            {
                MessageBox.Show("Exito al grabar");
                this.Close();
            }
        }
    }
}
