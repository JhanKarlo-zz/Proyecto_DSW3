using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUbigeo" en el código y en el archivo de configuración a la vez.
    public class ServicioUbigeo : IServicioUbigeo
    {
        hotelproEntities1 MiHotel = new HotelWCF.hotelproEntities1();

        public UbigeoBE DevuelveUbigeo(string idUbigeo)
        {
            UbigeoBE objUbigeo = null;
            try
            {
                var ubigeo = (from u in MiHotel.Ubigeo
                             where u.id_Ubigeo == idUbigeo
                             select u).FirstOrDefault();
                if (ubigeo != null)
                {
                    objUbigeo = new UbigeoBE();
                    objUbigeo.idUbigeo = ubigeo.id_Ubigeo;
                    if (ubigeo.idPais == null)
                    {
                        objUbigeo.idDistrito = ubigeo.idDistrito;
                        objUbigeo.idProvincia = ubigeo.idProvincia;
                        objUbigeo.idDepartamento = ubigeo.idDepartamento;
                        objUbigeo.Distrito = ubigeo.Distrito;
                        objUbigeo.Provincia = ubigeo.Provincia;
                        objUbigeo.Departamento = ubigeo.Departamento;
                    }
                    else
                    {
                        objUbigeo.idContinente = ubigeo.idContinente;
                        objUbigeo.Continente = ubigeo.Departamento;
                        objUbigeo.idPais = ubigeo.idProvincia;
                        objUbigeo.Pais = ubigeo.Provincia;
                        objUbigeo.idCiudad = ubigeo.idDistrito;
                        objUbigeo.Ciudad = ubigeo.Distrito;
                    }
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
            return objUbigeo;
        }

        public List<UbigeoBE> ListarDepartamentos()
        {
            List<UbigeoBE> objListaDepartamentos = new List<UbigeoBE>();
            try
            {
                var query = (from u in MiHotel.Ubigeo
                             where u.idPais == null
                             select new
                             {
                                 id = u.idDepartamento,
                                 Nombre = u.Departamento
                             }).Distinct().OrderByDescending(c=> c.Nombre);
                foreach (var resultado in query)
                {
                    UbigeoBE objUbigeo = new UbigeoBE();
                    objUbigeo.idDepartamento = resultado.id;
                    objUbigeo.Departamento = resultado.Nombre;
                    objListaDepartamentos.Add(objUbigeo);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return objListaDepartamentos;
        }

        public List<UbigeoBE> ListarDistritosProvincia(string idDepartamento, string idProvincia)
        {
            List<UbigeoBE> objDistritosProvincia = new List<UbigeoBE>();
            try
            {
                var query = (from u in MiHotel.Ubigeo
                             where u.idPais == null
                             where u.idDepartamento == idDepartamento
                             where u.idProvincia == idProvincia
                             where u.idDistrito != "00"
                             select new
                             {
                                 id = u.idDistrito,
                                 Nombre = u.Distrito
                             }).Distinct().OrderByDescending(c => c.Nombre);
                foreach (var resultado in query)
                {
                    UbigeoBE objUbigeo = new UbigeoBE();
                    objUbigeo.idDistrito = resultado.id;
                    objUbigeo.Distrito = resultado.Nombre;
                    objDistritosProvincia.Add(objUbigeo);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return objDistritosProvincia;
        }

        public List<UbigeoBE> ListarProvinciasDepartamento(string idDepartamento)
        {
            List<UbigeoBE> objProvinciasDepartamento = new List<UbigeoBE>();
            try
            {
                var query = (from u in MiHotel.Ubigeo
                             where u.idPais == null
                             where u.idDepartamento == idDepartamento
                             where u.idProvincia != "00"
                             select new
                             {
                                 id = u.idProvincia,
                                 Nombre = u.Provincia
                             }).Distinct().OrderByDescending(c => c.Nombre);
                foreach (var resultado in query)
                {
                    UbigeoBE objUbigeo = new UbigeoBE();
                    objUbigeo.idProvincia = resultado.id;
                    objUbigeo.Provincia = resultado.Nombre;
                    objProvinciasDepartamento.Add(objUbigeo);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return objProvinciasDepartamento;
        }
    }
}
