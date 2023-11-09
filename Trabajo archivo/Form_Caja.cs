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
        GestorCaja gestorCaja;
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
                    gestorCaja= new GestorCaja(openFileDialog1.FileName);
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
            lst_Cajas.DataSource = null;
            lst_Cajas.DataSource = gestorCaja.ListarCajas(); 
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Caja caja = new Caja();
                caja.Nombre = txt_nombre.Text;
                caja.NumeroCaja = Convert.ToInt32(txt_caja.Text);


                gestorCaja.Agregar(caja);
                MostrarLista();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al agregar el archivo");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_Cajas.SelectedItem != null)
                {
                    Caja caja = (Caja)lst_Cajas.SelectedItem;
                    gestorCaja.ModificarCaja(caja.NumeroCaja, txt_nombre.Text, Convert.ToInt32(txt_caja.Text));
                    MostrarLista();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al modificar");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_Cajas.SelectedItem != null)
                {
                    Caja caja = (Caja)lst_Cajas.SelectedItem;
                    gestorCaja.EliminarCaja(caja.NumeroCaja);
                    MostrarLista();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al eliminar");
            }
        }
    }
}
