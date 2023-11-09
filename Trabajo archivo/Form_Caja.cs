using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_archivo
{
    public partial class Form_Caja : Form
    {
        Gestor gestor;
        public Form_Caja()
        {
            InitializeComponent();
        }

        private void btn_importar_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    gestor = new Gestor(openFileDialog1.FileName);
                    MostrarLista();
                    btn_agregar.Enabled = true;
                    btn_Eliminar.Enabled = true;
                    btn_modificar.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el archivo");
            }
        }

        void MostrarLista()
        {
            lst_Cajas.DataSource = gestor.ListarCajas(); 
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Caja caja = new Caja();
                caja.Nombre = lbl_nombre.Text;
                caja.NumeroCaja = Convert.ToInt32(lbl_numCaja.Text);


                gestor.Agregar(caja);
                MostrarLista();
            }
            catch (Exception x)
            {

                MessageBox.Show(x);
            }
        }
    }
}
