
namespace Trabajo_archivo
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cajas = new System.Windows.Forms.Button();
            this.btn_facturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cajas
            // 
            this.btn_cajas.Location = new System.Drawing.Point(53, 12);
            this.btn_cajas.Name = "btn_cajas";
            this.btn_cajas.Size = new System.Drawing.Size(223, 99);
            this.btn_cajas.TabIndex = 0;
            this.btn_cajas.Text = "Cajas";
            this.btn_cajas.UseVisualStyleBackColor = true;
            this.btn_cajas.Click += new System.EventHandler(this.btn_cajas_Click);
            // 
            // btn_facturas
            // 
            this.btn_facturas.Location = new System.Drawing.Point(53, 144);
            this.btn_facturas.Name = "btn_facturas";
            this.btn_facturas.Size = new System.Drawing.Size(223, 98);
            this.btn_facturas.TabIndex = 1;
            this.btn_facturas.Text = "facturas";
            this.btn_facturas.UseVisualStyleBackColor = true;
            this.btn_facturas.Click += new System.EventHandler(this.btn_facturas_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 278);
            this.Controls.Add(this.btn_facturas);
            this.Controls.Add(this.btn_cajas);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cajas;
        private System.Windows.Forms.Button btn_facturas;
    }
}

