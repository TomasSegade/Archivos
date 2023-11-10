using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Trabajo_archivo
{
    class GestorFacturas
    {
        public string Ruta { get; set; }
        public GestorFacturas(string ruta)
        {
            Ruta = ruta;
        }

        public List<Factura> ListarFacturas()
        {
            List<Factura> facturas = new List<Factura>();
            FileStream fs = new FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Factura factura = new Factura(linea);
                    facturas.Add(factura);
                    linea = reader.ReadLine();
                }
            }
            fs.Close();
            return facturas;
        }

        public void AgregarFactura(Factura factura)
        {
            FileStream fs = new FileStream(Ruta, FileMode.Append, FileAccess.Write);

            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(factura.GenerarRegistro());
            }
            fs.Close();
        }

        public void ModificarFactura(int numFactura, int cajaNueva, int facturaNueva, double montoNuevo)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Factura factura = new Factura(linea);
                    if (factura.NumeroFactura == numFactura)
                    {
                        linea = $"{cajaNueva},{facturaNueva},{montoNuevo}";
                        output += linea + Environment.NewLine;
                        linea = reader.ReadLine();
                    }
                    else
                    {
                        output += linea + Environment.NewLine;
                        linea = reader.ReadLine();
                    }
                }
            }
            fs.Close();

            fs = new FileStream(Ruta, FileMode.Truncate, FileAccess.Write);

            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();
        }

        public  void EliminarFactura(int numFactura)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Factura factura = new Factura(linea);
                    if (factura.NumeroFactura != numFactura)
                    {
                        output += linea + Environment.NewLine;
                        
                    }
                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(Ruta, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();
        }

    }
}
