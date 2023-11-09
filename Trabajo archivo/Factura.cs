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

        }

        public string GenerarRegistro()
        {
            return $"{NumeroFactura};{NumeroCaja};{Monto}";
        }

        public override string ToString()
        {
            return string.Format($"{NumeroFactura} {NumeroCaja} {Monto}");
        }
    }
}
