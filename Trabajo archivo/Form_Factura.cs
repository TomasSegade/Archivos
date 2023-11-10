using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_archivo
{
    public partial class Form_Factura : Form
    {
        GestorFacturas gestorFacturas;
        public Form_Factura()
        {
            InitializeComponent();
        }

        private void btn_importar_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    gestorFacturas = new GestorFacturas(openFileDialog1.FileName);
                    MostrarLista();
                    btn_agregar.Enabled = true;
                    btn_modificar.Enabled = true;
                    btn_Eliminar.Enabled = true;
                   
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar el archivo");
            }
        }
        private void MostrarLista()
        {
            lst_facturas.DataSource = null;
            lst_facturas.DataSource = gestorFacturas.ListarFacturas();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_caja.Text.Length > 0 && txt_factura.Text.Length > 0 && txt_monto.Text.Length > 0)
                {
                    Factura factura = new Factura();
                    factura.NumeroCaja = Convert.ToInt32(txt_caja.Text);
                    factura.NumeroFactura = Convert.ToInt32(txt_factura.Text);
                    factura.Monto = Convert.ToDouble(txt_monto.Text);

                    gestorFacturas.AgregarFactura(factura);
                    MostrarLista();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al agregar");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_facturas.SelectedItem != null)
                {
                    if (txt_caja.Text.Length > 0 && txt_factura.Text.Length > 0 && txt_monto.Text.Length > 0)
                    {
                        Factura facturaAModificadar = (Factura)lst_facturas.SelectedItem;
                        int cajaNueva = Convert.ToInt32(txt_caja.Text);
                        int facturaNueva = Convert.ToInt32(txt_factura.Text);
                        double montoNuevo = Convert.ToDouble(txt_monto.Text);
                        gestorFacturas.ModificarFactura(facturaAModificadar.NumeroFactura, cajaNueva, facturaNueva, montoNuevo);
                        MostrarLista();
                    }
                    else
                    {
                        MessageBox.Show("Datos incompletos");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un item");
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
                if (lst_facturas.SelectedItem != null)
                {
                    Factura facturaAEliminar = (Factura)lst_facturas.SelectedItem;

                    gestorFacturas.EliminarFactura(facturaAEliminar.NumeroFactura);
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
