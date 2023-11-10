using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_archivo
{
    public class GestorCaja
    {
        public string Ruta { get; set; }
        public GestorCaja(string ruta)
        {
            Ruta = ruta;
        }

        public List<Caja> ListarCajas()
        {
            List<Caja> cajas = new List<Caja>();
            FileStream fileStream = new FileStream(Ruta,FileMode.OpenOrCreate,FileAccess.Read);

            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                string linea = streamReader.ReadLine();
                while (linea != null)
                {
                    Caja caja = new Caja(linea);
                    cajas.Add(caja);
                    linea = streamReader.ReadLine();
                }
            }
            fileStream.Close();
            return cajas;
        }

        public void Agregar(Caja caja)
        {
            FileStream fileStream = new FileStream(Ruta, FileMode.Append, FileAccess.Write);

            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {

                streamWriter.WriteLine(caja.GenerarRegistro());
            }

            fileStream.Close();

        }

        public void EliminarCaja(int numCaja)
        {
            string output = string.Empty;
            FileStream fs = new FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();

                while (linea != null)
                {
                    Caja caja = new Caja(linea);
                    if (caja.NumeroCaja != numCaja)
                    {
                        output += linea + Environment.NewLine;
                    }

                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(Ruta, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter write = new StreamWriter(fs))
            {
                write.Write(output);
            }
            fs.Close();
        }

        public void ModificarCaja(int numCaja, string cajaNueva, int numNuevo)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                { 
                    
                    Caja caja = new Caja(linea);
                    if (caja.NumeroCaja == numCaja)
                    {
                        linea = $"{numNuevo};{cajaNueva}";
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
            using (StreamWriter writer = new StreamWriter (fs))
            {
                writer.Write(output);
            }
            fs.Close();
        }
    }
}
