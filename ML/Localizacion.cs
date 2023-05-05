using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Localizacion
    {
        public int IdPunto { get; set; }
        public string Nombre { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string Fecha { get; set; }
        public List<Object> Localizaciones { get; set; }
    }
}
