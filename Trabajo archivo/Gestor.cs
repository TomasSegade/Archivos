using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_archivo
{
    public class Gestor
    {
        public string Ruta { get; set; }
        public Gestor(string ruta)
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
    }
}
