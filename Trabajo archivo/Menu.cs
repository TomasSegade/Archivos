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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_cajas_Click(object sender, EventArgs e)
        {
            Form_Caja form_Caja = new Form_Caja();
            form_Caja.Show();
        }

        private void btn_facturas_Click(object sender, EventArgs e)
        {
            Form_Factura form_Factura = new Form_Factura();
            form_Factura.Show();
        }
    }
}
