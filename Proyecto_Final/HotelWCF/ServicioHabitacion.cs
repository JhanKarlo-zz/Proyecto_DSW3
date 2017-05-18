using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioHabitacion" in both code and config file together.
    public class ServicioHabitacion : IServicioHabitacion
    {
        hotelproEntities MiHotel = new hotelproEntities();
        public List<HabitacionBE> ListarHabitacionesLibres(byte IdSede, DateTime FechaInicio, DateTime FechaFin)
        {
            List<HabitacionBE> ObjListaHabitacion = new List<HabitacionBE>();
            ObjListaHabitacion = ListarHabitacionPorFecha(IdSede, FechaInicio, FechaFin);
            ObjListaHabitacion = (from o in ObjListaHabitacion where o.IdEstado == 0 select o).ToList();
            return ObjListaHabitacion;
        }

        public List<HabitacionBE> ListarHabitacionPorFecha(byte IdSede, DateTime FechaInicio, DateTime FechaFin)
        {
            List<HabitacionBE> ObjListaHabitacion = new List<HabitacionBE>();

            IQueryable<Habitacion> query = (from o in MiHotel.Habitacion
                                            where o.id_Sede == IdSede
                                            select o);
            foreach (var resultado in query)
            {
                HabitacionBE objHabitacionBE = new HabitacionBE();
                objHabitacionBE.IdHabitacion = resultado.id_Habitacion;
                objHabitacionBE.Descripcion = resultado.Descripcion;
                objHabitacionBE.IdSede = resultado.id_Sede;
                objHabitacionBE.IdTipo = (byte)resultado.id_Tipo_Habitacion;
                objHabitacionBE.Piso = (int)resultado.Piso;
                objHabitacionBE.Precio = (float)resultado.Precio;
                ObjListaHabitacion.Add(objHabitacionBE);
            }
            foreach (var resultado in ObjListaHabitacion)
            {
                resultado.IdEstado = (from o in MiHotel.Reserva
                                      where o.id_Habitacion == resultado.IdHabitacion
                                      where (o.Fecha_Inicio_Reserva >= FechaInicio.Date && o.Fecha_Inicio_Reserva <= FechaFin.Date)
                                 || (o.Fecha_Fin_Reserva >= FechaInicio.Date && o.Fecha_Fin_Reserva <= FechaFin.Date)
                                      select o.id_Estado_Reserva).FirstOrDefault();
                switch (resultado.IdEstado)
                {
                    case 0:
                        resultado.DescripcionEstado = "LIBRE";
                        break;
                    case 1:
                        resultado.DescripcionEstado = "RESERVADO";
                        break;

                    case 2:
                        resultado.DescripcionEstado = "PAGADO";
                        break;

                    case 3:
                        resultado.DescripcionEstado = "ANULADO";
                        break;
                    default:
                        break;
                }
            }
            return ObjListaHabitacion;
        }

        public List<HabitacionBE> ListarPrecioHabitacionesPorSede(byte IdSede)
        {
            List<HabitacionBE> ObjListaHabitacion = new List<HabitacionBE>();
            var objs = (from c in MiHotel.Habitacion
                        orderby c.id_Tipo_Habitacion
                        select c).GroupBy(g => g.id_Tipo_Habitacion).Select(x => x.FirstOrDefault());
            foreach (var resultado in objs)
            {
                HabitacionBE objHabitacionBE = new HabitacionBE();
                objHabitacionBE.IdHabitacion = resultado.id_Habitacion;
                objHabitacionBE.Descripcion = resultado.Descripcion;
                objHabitacionBE.IdSede = resultado.id_Sede;
                objHabitacionBE.IdTipo = (byte)resultado.id_Tipo_Habitacion;
                objHabitacionBE.Piso = (int)resultado.Piso;
                objHabitacionBE.Precio = (float)resultado.Precio;
                ObjListaHabitacion.Add(objHabitacionBE);
            }
            return ObjListaHabitacion;
        }
    }
}
