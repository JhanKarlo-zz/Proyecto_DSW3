using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEscritorio
{
    public class ReservaBL
    {
        BD_TestEntities MiTest = new BD_TestEntities();
        public short InsertarReserva(Reserva objReserva)
        {
            try
            {
                MiTest.Reserva.Add(objReserva);
                MiTest.SaveChanges();
                short id = objReserva.id_Reserva;
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Reserva> ListaReservaPendienteCliente(int? id_Cliente)
        {
            List<Reserva> objListaReserva = new List<Reserva>();
            try
            {
                if (id_Cliente==null)
                {
                    return objListaReserva;
                }
                var query = (from o in MiTest.Reserva
                             where o.id_Cliente == id_Cliente
                             where o.id_Estado_Reserva == 1 //Pendientes
                             select o);
                foreach (var resultado in query)
                {
                    Reserva objReserva = new Reserva();
                    objReserva.id_Reserva = resultado.id_Reserva;
                    objReserva.id_Cliente = resultado.id_Cliente;
                    objReserva.id_Estado_Reserva = resultado.id_Estado_Reserva;
                    objReserva.id_Habitacion = resultado.id_Habitacion;
                    objReserva.Fecha_Inicio_Reserva = resultado.Fecha_Inicio_Reserva;
                    objReserva.Fecha_Fin_Reserva = resultado.Fecha_Fin_Reserva;
                    objReserva.Fecha_Registro = resultado.Fecha_Registro;
                    objListaReserva.Add(objReserva);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaReserva;
        }
        public Boolean PagarReserva(Reserva objReserva)
        {
            Reserva reserva = MiTest.Reserva.Find(objReserva.id_Reserva);
            reserva.id_Estado_Reserva = 2;
            MiTest.SaveChanges();
            return true;
        }
        public Reserva DevuelveReserva(short idReserva)
        {
            Reserva reserva = (from o in MiTest.Reserva
                               where o.id_Reserva == idReserva
                               select o).FirstOrDefault();
            return reserva;
        }
    }
}
