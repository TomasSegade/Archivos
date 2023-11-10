using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_archivo
{
    public class Factura
    {
        public int NumeroFactura { get; set; }
        public int NumeroCaja { get; set; }
        public double Monto { get; set; }


        public Factura()
        {

        }

        public Factura(string linea)
        {
            string[] datos;

            datos = linea.Split(',');
            NumeroFactura = Convert.ToInt32(datos[0]);
            NumeroCaja = Convert.ToInt32(datos[1]);
            Monto = Convert.ToDouble(datos[2]);

        }

        public string GenerarRegistro()
        {
            return $"{NumeroFactura},{NumeroCaja},{Monto}";
        }

        public override string ToString()
        {
            return string.Format($"{NumeroFactura} {NumeroCaja} {Monto}");
        }
    }
}
