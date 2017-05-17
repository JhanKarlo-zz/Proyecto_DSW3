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
        hotelproEntities MiHotel = new HotelWCF.hotelproEntities();
        public bool ActualizarCliente(ClienteBE objClienteBE)
        {
            Boolean retorno = false;
            try
            {
                Cliente cliente = MiHotel.Cliente.Find(objClienteBE.IdCliente);

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
                Cliente cliente = (from o in MiHotel.Cliente
                                   where o.NroDocumento == dni
                                   select o).First();
                if (cliente != null)
                {
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
            return objClienteBE;
        }

        public bool InsertarCliente(ClienteBE objClienteBE)
        {
            Boolean retorno = false;
            try
            {
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
