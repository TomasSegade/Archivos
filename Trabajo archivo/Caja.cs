using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_archivo
{
    public class Caja
    {
        public int NumeroCaja { get; set; }
        public string Nombre { get; set; }
        public Caja()
        {

        }

        public Caja(string linea)
        {
            string[] datos;

            datos = linea.Split(';');
            NumeroCaja = Convert.ToInt32(datos[0]);
            Nombre = datos[1];
          
        }

        public string GenerarRegistro()
        {
            return $"{NumeroCaja};{Nombre}";
        }

        public override string ToString()
        {
            return string.Format($"{NumeroCaja} {Nombre}");
        }
    }
}
