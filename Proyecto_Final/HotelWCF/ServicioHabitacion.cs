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
        hotelproEntities1 MiHotel = new hotelproEntities1();

        public List<HabitacionBE> ListarHabitacionPorFecha(byte IdSede, DateTime FechaInicio, DateTime FechaFin)
        {
            //Creamos una lista de nuestro objeto "HabitacionBE"
            List<HabitacionBE> ObjListaHabitacion = new List<HabitacionBE>();
            //Buscamos solo las habitaciones que estan activas
            IQueryable<Habitacion> query = (from h in MiHotel.Habitacion
                                            where h.id_Sede == IdSede
                                            where h.id_Estado_Habitacion == 1
                                            select h);

            //Recorremos el resultado
            foreach (var resultado in query)
            {
                //Creamos nuevo objeto de la clase "HabitacionBE" y lo vamos agregando a la lista de habitaciones por cada habitación encontrada
                HabitacionBE objHabitacionBE = new HabitacionBE();
                objHabitacionBE.IdHabitacion = resultado.id_Habitacion;
                objHabitacionBE.Descripcion = resultado.Descripcion;
                objHabitacionBE.IdSede = resultado.id_Sede;
                objHabitacionBE.IdTipo = (byte)resultado.id_Tipo_Habitacion;
                //Asigna la descripcién de acuerdo al tipo
                objHabitacionBE.DescripcionTipo = objHabitacionBE.DevuelveDescripcionTipo(objHabitacionBE.IdTipo);
                objHabitacionBE.Piso = (int)resultado.Piso;
                objHabitacionBE.Precio = (float)resultado.Precio;
                ObjListaHabitacion.Add(objHabitacionBE);
            }

            //Recorremos toda la lista de Habitaciones encontradas
            foreach (var resultado in ObjListaHabitacion)
            {
                //Reservas por fecha de cada habitacion
                //var reservas = (from r in MiHotel.Reserva
                //             where r.id_Habitacion == resultado.IdHabitacion
                //             where r.id_Estado_Reserva != 3//Que no esté anulada
                //             where (FechaInicio.Date >= r.Fecha_Inicio_Reserva && FechaInicio.Date <= r.Fecha_Fin_Reserva)
                //        || (FechaFin.Date >= r.Fecha_Inicio_Reserva && FechaFin.Date <= r.Fecha_Fin_Reserva)
                //             select r).FirstOrDefault();

                //Por cada habitación encontrada busca si existe una reserva de acuerdo a las fechas encontradas que no este anulada
                if (resultado.IdEstado==0)
                {
                    resultado.IdEstado = (from r in MiHotel.Reserva
                                          where r.id_Habitacion == resultado.IdHabitacion
                                          where r.id_Estado_Reserva != 3//Que no esté anulada
                                          where (FechaInicio.Date >= r.Fecha_Inicio_Reserva && FechaInicio.Date <= r.Fecha_Fin_Reserva)
                        || (FechaFin.Date >= r.Fecha_Inicio_Reserva && FechaFin.Date <= r.Fecha_Fin_Reserva)
                                          select r.id_Estado_Reserva).FirstOrDefault();
                }
                //Asigna la descripción de acuerdo al estado
                resultado.DescripcionEstado = resultado.DevuelveDescripcionEstado(resultado.IdEstado);
            }
            return ObjListaHabitacion;
        }

        public List<HabitacionBE> ListarPrecioHabitacionesPorSede(byte IdSede)
        {
            //Creamos una lista de nuestro objeto "HabitacionBE"
            List<HabitacionBE> ObjListaHabitacion = new List<HabitacionBE>();

            //devuelve todas las habitaciones de acuerdo al IdSede que recibe la función y la ordena por el tipo de habitación
            var query = (from h in MiHotel.Habitacion
                        orderby h.id_Tipo_Habitacion
                        select h).GroupBy(g => g.id_Tipo_Habitacion).Select(x => x.FirstOrDefault());
            //Recorre el resultado
            foreach (var resultado in query)
            {
                //Crea una instancia de nuestro objeto "HabitacionBE" y se le asigna todos los datos encontrados del objeto "Habitacion" de la base de datos
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

        public List<HabitacionBE> ListarHabitacionesLibres(byte IdSede, DateTime FechaInicio, DateTime FechaFin)
        {
            //Creamos una lista de nuestro objeto "HabitacionBE"
            List<HabitacionBE> ObjListaHabitacion = new List<HabitacionBE>();
            //Llamamos al metodo que devuelve la lista del metodo ListarHabitacionPorFecha
            ObjListaHabitacion = ListarHabitacionPorFecha(IdSede, FechaInicio, FechaFin);
            //Filtramos a las habitaciones libres
            ObjListaHabitacion = (from o in ObjListaHabitacion where o.IdEstado == 0 select o).ToList();
            return ObjListaHabitacion;
        }

        public HabitacionBE DevuelveHabitacion(int idHabitacion)
        {
            HabitacionBE objHabitacionBE = null;
            try
            {
                var habitacion = (from h in MiHotel.Habitacion
                              where h.id_Habitacion == idHabitacion
                                  select h).FirstOrDefault();
                if (habitacion != null)
                {
                    objHabitacionBE = new HabitacionBE();
                    objHabitacionBE.Descripcion = habitacion.Descripcion;
                    objHabitacionBE.IdEstado = habitacion.id_Estado_Habitacion;
                    objHabitacionBE.IdHabitacion = habitacion.id_Habitacion;
                    objHabitacionBE.IdSede = habitacion.id_Sede;
                    objHabitacionBE.IdTipo = (byte)habitacion.id_Tipo_Habitacion;
                    objHabitacionBE.Piso = (int)habitacion.Piso;
                    objHabitacionBE.Precio = (double)habitacion.Precio;
                    objHabitacionBE.DescripcionEstado = objHabitacionBE.DevuelveDescripcionEstado(objHabitacionBE.IdEstado);
                    objHabitacionBE.DescripcionTipo = objHabitacionBE.DevuelveDescripcionTipo(objHabitacionBE.IdTipo);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return objHabitacionBE;
        }

        public List<SedeBE> ListarSede()
        {
            List<SedeBE> objListaSede = new List<SedeBE>();
            try
            {
                var resultado = (from s in MiHotel.Sede
                                 select new
                                 {
                                     id = s.id_Sede,
                                     Nombre = s.Nombre,
                                     Direccion = s.Direccion,
                                     idUbigeo = s.id_Ubigeo
                                 }).OrderByDescending(c => c.Nombre);
                foreach (var sede in resultado)
                {
                    SedeBE objSedeBE = new SedeBE();
                    objSedeBE.idSede = sede.id;
                    objSedeBE.Nombre = sede.Nombre;
                    objSedeBE.Direccion = sede.Direccion;
                    objSedeBE.idUbigeo = sede.idUbigeo;
                    objListaSede.Add(objSedeBE);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return objListaSede;
        }
    }
}
