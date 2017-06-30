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
        public Boolean InsertarReserva(Reserva objReserva)
        {
            try
            {
                MiTest.Reserva.Add(objReserva);
                MiTest.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
