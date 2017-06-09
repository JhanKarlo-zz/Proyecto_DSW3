using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioConsumo" in both code and config file together.
    public class ServicioConsumo : IServicioConsumo
    {
        hotelproEntities1 MiHotel = new hotelproEntities1();
        public bool ActualizarConsumoReserva(ConsumoBE objConsumoBE)
        {
            Boolean retorno = false;
            try
            {
                //Buscamos Consumo en la base de datos
                Consumo consumo = MiHotel.Consumo.Find(objConsumoBE.IdConsumo);
                //Si encuentra consumo entra al if
                if (consumo != null)
                {
                    //asigna todo los datos nuestro objeto "ConsumoBE" a "Consumo" de la base de datos
                    consumo.id_Estado_Consumo = objConsumoBE.IdEstadoConsumo;
                    consumo.id_Producto = objConsumoBE.IdProducto;
                    consumo.Fecha = objConsumoBE.Fecha;
                    consumo.cantidad = objConsumoBE.Cantidad;
                    consumo.id_Reserva = objConsumoBE.IdReserva;
                    //Guardamos cambios
                    MiHotel.SaveChanges();
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return retorno;
        }

        public bool InsertarConsumoReserva(ConsumoBE objConsumoBE)
        {
            Boolean retorno = false;
            try
            {
                //creamos nueva instancia del objeto "Consumo" de la base de datos y se asigna los datos de nuetro objeto "ConsumoBE"
                Consumo consumo = new Consumo();
                consumo.id_Estado_Consumo = 1;
                consumo.id_Producto = objConsumoBE.IdProducto;
                consumo.Fecha = objConsumoBE.Fecha;
                consumo.cantidad = objConsumoBE.Cantidad;
                consumo.id_Reserva = objConsumoBE.IdReserva;
                MiHotel.Consumo.Add(consumo);
                MiHotel.SaveChanges();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return retorno;
        }

        public List<ConsumoBE> ListarConsumoReserva(short IdReserva)
        {
            //Creamos una lista de Consumos
            List<ConsumoBE> objListaConsumo = new List<ConsumoBE>();
            try
            {
                //Buscamos todos los consumo por el IdReserva que recibe como parametro
                var query = (from c in MiHotel.Consumo
                             where c.id_Reserva == IdReserva
                             select c);

                //Recorre el resultado
                foreach (var resultado in query)
                {
                    //Crea un nuevo objeto de nuestra clase "ConsumoBE" y agrega los datos del resultado
                    ConsumoBE objConsumoBE = new ConsumoBE();
                    objConsumoBE.IdConsumo = resultado.id_Consumo;
                    objConsumoBE.IdEstadoConsumo = resultado.id_Estado_Consumo;
                    objConsumoBE.DescripcionEstado = objConsumoBE.DevuelveDescripcionEstado(objConsumoBE.IdEstadoConsumo);
                    objConsumoBE.IdProducto = resultado.id_Producto;
                    objConsumoBE.Fecha = resultado.Fecha;
                    objConsumoBE.Cantidad = resultado.cantidad;
                    objConsumoBE.IdReserva = resultado.id_Reserva;
                    objListaConsumo.Add(objConsumoBE);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaConsumo;
        }
    }
}
