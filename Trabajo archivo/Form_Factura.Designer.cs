
namespace Trabajo_archivo
{
    partial class Form_Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.lst_facturas = new System.Windows.Forms.ListBox();
            this.txt_factura = new System.Windows.Forms.TextBox();
            this.lbl_numFact = new System.Windows.Forms.Label();
            this.txt_caja = new System.Windows.Forms.TextBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.lbl_numCaja = new System.Windows.Forms.Label();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_importar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(273, 145);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(247, 34);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(273, 282);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(247, 33);
            this.btn_Eliminar.TabIndex = 1;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // lst_facturas
            // 
            this.lst_facturas.FormattingEnabled = true;
            this.lst_facturas.Location = new System.Drawing.Point(12, 12);
            this.lst_facturas.Name = "lst_facturas";
            this.lst_facturas.Size = new System.Drawing.Size(237, 173);
            this.lst_facturas.TabIndex = 2;
            // 
            // txt_factura
            // 
            this.txt_factura.Location = new System.Drawing.Point(386, 28);
            this.txt_factura.Name = "txt_factura";
            this.txt_factura.Size = new System.Drawing.Size(134, 20);
            this.txt_factura.TabIndex = 3;
            // 
            // lbl_numFact
            // 
            this.lbl_numFact.AutoSize = true;
            this.lbl_numFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numFact.Location = new System.Drawing.Point(265, 28);
            this.lbl_numFact.Name = "lbl_numFact";
            this.lbl_numFact.Size = new System.Drawing.Size(115, 18);
            this.lbl_numFact.TabIndex = 4;
            this.lbl_numFact.Text = "N° De Factura";
            // 
            // txt_caja
            // 
            this.txt_caja.Location = new System.Drawing.Point(386, 68);
            this.txt_caja.Name = "txt_caja";
            this.txt_caja.Size = new System.Drawing.Size(134, 20);
            this.txt_caja.TabIndex = 7;
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(386, 105);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(134, 20);
            this.txt_monto.TabIndex = 8;
            // 
            // lbl_numCaja
            // 
            this.lbl_numCaja.AutoSize = true;
            this.lbl_numCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numCaja.Location = new System.Drawing.Point(265, 68);
            this.lbl_numCaja.Name = "lbl_numCaja";
            this.lbl_numCaja.Size = new System.Drawing.Size(92, 18);
            this.lbl_numCaja.TabIndex = 9;
            this.lbl_numCaja.Text = "N° De Caja";
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.Location = new System.Drawing.Point(265, 105);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(56, 18);
            this.lbl_monto.TabIndex = 10;
            this.lbl_monto.Text = "Monto";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(273, 214);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(247, 32);
            this.btn_modificar.TabIndex = 11;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_importar
            // 
            this.btn_importar.Location = new System.Drawing.Point(12, 214);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(237, 80);
            this.btn_importar.TabIndex = 12;
            this.btn_importar.Text = "Importar Facturas";
            this.btn_importar.UseVisualStyleBackColor = true;
            // 
            // Form_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 329);
            this.Controls.Add(this.btn_importar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.lbl_numCaja);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.txt_caja);
            this.Controls.Add(this.lbl_numFact);
            this.Controls.Add(this.txt_factura);
            this.Controls.Add(this.lst_facturas);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Name = "Form_Factura";
            this.Text = "Facturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.ListBox lst_facturas;
        private System.Windows.Forms.TextBox txt_factura;
        private System.Windows.Forms.Label lbl_numFact;
        private System.Windows.Forms.TextBox txt_caja;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label lbl_numCaja;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_importar;
    }
}