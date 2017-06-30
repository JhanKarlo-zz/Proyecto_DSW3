using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEscritorio
{
    public class ClienteBL
    {
        BD_TestEntities MiTest = new BD_TestEntities();
        public Cliente DevuelveClienteDNI(string dni)
        {
            try
            {
                Cliente objCliente = (from c in MiTest.Cliente
                                   where c.NroDocumento == dni
                                   select c).FirstOrDefault();
                return objCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean InsertarCliente(Cliente objCliente)
        {
            try
            {
                MiTest.Cliente.Add(objCliente);
                MiTest.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean ActualizarCliente(Cliente objCliente)
        {
            Boolean retorno = false;
            try
            {
                //Buscarmos Cliente mediante el Id
                Cliente cliente = MiTest.Cliente.Find(objCliente.id_Cliente);

                //Actualizamos los datos del "Cliente" de acuerdo a lo que envias en el "ClienteBE"
                cliente.Apellido_Paterno = objCliente.Apellido_Paterno;
                cliente.Apellido_Materno = objCliente.Apellido_Materno;
                cliente.Nombres = objCliente.Nombres;
                cliente.NroDocumento = objCliente.NroDocumento;
                cliente.Correo = objCliente.Correo;
                cliente.Direccion = objCliente.Direccion;
                cliente.id_Ubigeo = objCliente.id_Ubigeo;
                cliente.Telefono = objCliente.Telefono;

                //Guardas cambios en la base de datos
                MiTest.SaveChanges();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return retorno;
        }
    }
}
