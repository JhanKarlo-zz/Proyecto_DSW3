using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoServicios;

namespace TestWindows
{
    public partial class Ubigeo_Nacional : UserControl
    {
        ServiciosUbigeo objServicioUbigeo = new ServiciosUbigeo();
        public Ubigeo_Nacional()
        {
            InitializeComponent();
        }

        private void Ubigeo_Nacional_Load(object sender, EventArgs e)
        {
            cargarDepartamentos();
        }
        private void cargarDepartamentos()
        {
            cboDepartamento.DataSource = objServicioUbigeo.ListarDepartamentos();
            cboDepartamento.ValueMember = "idDepartamento";
            cboDepartamento.DisplayMember = "Departamento";
        }
    }
}
