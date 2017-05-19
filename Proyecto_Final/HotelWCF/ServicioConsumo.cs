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
                Consumo consumo = MiHotel.Consumo.Find(objConsumoBE.IdConsumo);

                consumo.id_Estado_Consumo = objConsumoBE.IdEstadoConsumo;
                consumo.id_Producto = objConsumoBE.IdProducto;
                consumo.Fecha = objConsumoBE.Fecha;
                consumo.cantidad = objConsumoBE.Cantidad;
                consumo.id_Reserva = objConsumoBE.IdReserva;
                MiHotel.SaveChanges();
                retorno = true;
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
            List<ConsumoBE> objListaConsumo = new List<ConsumoBE>();
            try
            {
                var query = (from o in MiHotel.Consumo
                             where o.id_Reserva == IdReserva
                             select o);
                foreach (var resultado in query)
                {
                    ConsumoBE objConsumoBE = new ConsumoBE();
                    objConsumoBE.IdConsumo = resultado.id_Consumo;
                    objConsumoBE.IdEstadoConsumo = resultado.id_Estado_Consumo;
                    objConsumoBE.IdProducto = resultado.id_Producto;
                    objConsumoBE.Fecha = objConsumoBE.Fecha;
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
