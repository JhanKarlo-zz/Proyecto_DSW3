using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioCliente" in both code and config file together.
    public class ServicioCliente : IServicioCliente
    {
        hotelproEntities1 MiHotel = new HotelWCF.hotelproEntities1();
        public bool ActualizarCliente(ClienteBE objClienteBE)
        {
            Boolean retorno = false;
            try
            {
                //Buscarmos Cliente mediante el Id
                Cliente cliente = MiHotel.Cliente.Find(objClienteBE.IdCliente);

                //Actualizamos los datos del "Cliente" de acuerdo a lo que envias en el "ClienteBE"
                cliente.Apellido_Paterno = objClienteBE.ApellidoPaterno;
                cliente.Apellido_Materno = objClienteBE.ApellidoMaterno;
                cliente.Nombres = objClienteBE.Nombres;
                cliente.NroDocumento = objClienteBE.NroDocumento;
                cliente.Correo = objClienteBE.Correo;
                cliente.Direccion = objClienteBE.Direccion;
                cliente.Fecha_Nacimiento = objClienteBE.FechaNacimiento;
                cliente.id_Ubigeo = objClienteBE.IdUbigeo;
                cliente.id_Tipo_Cliente = objClienteBE.IdTipoCliente;
                cliente.Telefono_Casa = objClienteBE.TelefonoCasa;
                cliente.Telefono_Celular = objClienteBE.TelefonoCelular;

                //Guardas cambios en la base de datos
                MiHotel.SaveChanges();
                retorno = true;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return retorno;
        }

        public ClienteBE DevuelveClientePorDNI(string dni)
        {
            ClienteBE objClienteBE = null;
            try
            {
                //Busca cliente por el dni enviado
                Cliente cliente = (from c in MiHotel.Cliente
                                   where c.NroDocumento == dni
                                   select c).First();
                //Si encuentra datos ingresa al if
                if (cliente != null)
                {
                    //crea una nueva instancia del objeto ClienteBE y se llena con la información encontrada
                    objClienteBE = new ClienteBE();
                    objClienteBE.IdCliente = cliente.id_Cliente;
                    objClienteBE.ApellidoPaterno = cliente.Apellido_Paterno;
                    objClienteBE.ApellidoMaterno = cliente.Apellido_Materno;
                    objClienteBE.Nombres = cliente.Nombres;
                    objClienteBE.NroDocumento = cliente.NroDocumento;
                    objClienteBE.Correo = cliente.Correo;
                    objClienteBE.Direccion = cliente.Direccion;
                    objClienteBE.FechaNacimiento = (DateTime)cliente.Fecha_Nacimiento;
                    objClienteBE.IdUbigeo = cliente.id_Ubigeo;
                    objClienteBE.IdTipoCliente = (byte)cliente.id_Tipo_Cliente;
                    objClienteBE.TelefonoCasa = cliente.Telefono_Casa;
                    objClienteBE.TelefonoCelular = cliente.Telefono_Celular;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //Retornamos el objeto
            return objClienteBE;
        }

        public bool InsertarCliente(ClienteBE objClienteBE)
        {
            Boolean retorno = false;
            try
            {
                //creamos un nuevo cliente con el objeto "Cliente" de la base de datos
                //y se le asigna todos los datos traidos por nuestra clase "ClienteBE"
                Cliente cliente = new Cliente();
                cliente.Apellido_Paterno = objClienteBE.ApellidoPaterno;
                cliente.Apellido_Materno = objClienteBE.ApellidoMaterno;
                cliente.Nombres = objClienteBE.Nombres;
                cliente.NroDocumento = objClienteBE.NroDocumento;
                cliente.Correo = objClienteBE.Correo;
                cliente.Direccion = objClienteBE.Direccion;
                cliente.Fecha_Nacimiento = objClienteBE.FechaNacimiento;
                cliente.id_Ubigeo = objClienteBE.IdUbigeo;
                cliente.id_Tipo_Cliente = objClienteBE.IdTipoCliente;
                cliente.Telefono_Casa = objClienteBE.TelefonoCasa;
                cliente.Telefono_Celular = objClienteBE.TelefonoCelular;
                MiHotel.Cliente.Add(cliente);
                MiHotel.SaveChanges();
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
