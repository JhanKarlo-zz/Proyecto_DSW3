using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioReserva" in both code and config file together.
    public class ServicioReserva : IServicioReserva
    {
        hotelproEntities1 MiHotel = new hotelproEntities1();
        public bool ActualizarReserva(ReservaBE objReserva)
        {
            Boolean retorno = false;
            try
            {
                Reserva reserva = MiHotel.Reserva.Find(objReserva.IdReserva);
                reserva.id_Cliente = objReserva.IdCliente;
                reserva.id_Estado_Reserva = objReserva.IdEstadoReserva;
                reserva.id_Habitacion = objReserva.IdHabitacion;
                reserva.Fecha_Ingreso = objReserva.FechaIngreso;
                reserva.Fecha_Salida = objReserva.FechaSalida;
                reserva.Fecha_Inicio_Reserva = objReserva.FechaInicioReserva;
                reserva.Fecha_Fin_Reserva = objReserva.FechaFinReserva;
                reserva.Fecha_Registro = objReserva.FechaRegistro;
                MiHotel.SaveChanges();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return retorno;
        }

        public List<ReservaBE> DevuelveReservasCliente(byte IdCliente)
        {
            List<ReservaBE> objListaReserva = new List<ReservaBE>();
            try
            {
                var query = (from o in MiHotel.Reserva
                             where o.id_Cliente == IdCliente
                             select o);
                foreach (var resultado in query)
                {
                    ReservaBE objReservaBE = new ReservaBE();
                    objReservaBE.IdReserva = resultado.id_Reserva;
                    objReservaBE.IdCliente = resultado.id_Cliente;
                    objReservaBE.IdEstadoReserva = resultado.id_Estado_Reserva;
                    objReservaBE.IdHabitacion = resultado.id_Habitacion;
                    objReservaBE.FechaIngreso = resultado.Fecha_Ingreso;
                    objReservaBE.FechaSalida = resultado.Fecha_Salida;
                    objReservaBE.FechaInicioReserva = resultado.Fecha_Inicio_Reserva;
                    objReservaBE.FechaFinReserva = resultado.Fecha_Fin_Reserva;
                    objReservaBE.FechaRegistro = resultado.Fecha_Registro;
                    objListaReserva.Add(objReservaBE);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaReserva;
        }
        
        public bool InsertarReserva(ReservaBE objReserva)
        {
            Boolean retorno = false;
            try
            {
                Reserva reserva = new Reserva();
                reserva.id_Cliente = objReserva.IdCliente;
                reserva.id_Estado_Reserva = objReserva.IdEstadoReserva;
                reserva.id_Habitacion = objReserva.IdHabitacion;
                reserva.Fecha_Ingreso = objReserva.FechaIngreso;
                reserva.Fecha_Salida = objReserva.FechaSalida;
                reserva.Fecha_Inicio_Reserva = objReserva.FechaInicioReserva;
                reserva.Fecha_Fin_Reserva = objReserva.FechaFinReserva;
                reserva.Fecha_Registro = objReserva.FechaRegistro;
                MiHotel.Reserva.Add(reserva);
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
