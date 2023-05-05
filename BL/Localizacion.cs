using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Localizacion
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.JRodriguezExamenPracticoMichelinEntities contex = new DL.JRodriguezExamenPracticoMichelinEntities())
                {
                    var query = contex.LocalizacionesGetAll().ToList();

                    if (query.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (var item in query)
                        {
                            ML.Localizacion punto = new ML.Localizacion();
                            punto.IdPunto = item.IdPunto;
                            punto.Nombre = item.Nombre;
                            punto.Latitud = item.Latitud;
                            punto.Longitud = item.Longitud;
                            punto.Fecha = item.FechaHora.Value.ToString("dd/MM/yyyy");

                            result.Objects.Add(punto);
                            result.Correct = true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
