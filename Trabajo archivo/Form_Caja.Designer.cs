
namespace Trabajo_archivo
{
    partial class Form_Caja
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
            this.btn_importar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.lbl_numCaja = new System.Windows.Forms.Label();
            this.txt_caja = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lst_Cajas = new System.Windows.Forms.ListBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_importar
            // 
            this.btn_importar.Location = new System.Drawing.Point(12, 214);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(237, 80);
            this.btn_importar.TabIndex = 23;
            this.btn_importar.Text = "Importar cajas";
            this.btn_importar.UseVisualStyleBackColor = true;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(273, 214);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(247, 32);
            this.btn_modificar.TabIndex = 22;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // lbl_numCaja
            // 
            this.lbl_numCaja.AutoSize = true;
            this.lbl_numCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numCaja.Location = new System.Drawing.Point(289, 67);
            this.lbl_numCaja.Name = "lbl_numCaja";
            this.lbl_numCaja.Size = new System.Drawing.Size(92, 18);
            this.lbl_numCaja.TabIndex = 20;
            this.lbl_numCaja.Text = "N° De Caja";
            // 
            // txt_caja
            // 
            this.txt_caja.Location = new System.Drawing.Point(386, 68);
            this.txt_caja.Name = "txt_caja";
            this.txt_caja.Size = new System.Drawing.Size(134, 20);
            this.txt_caja.TabIndex = 18;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(289, 27);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(68, 18);
            this.lbl_nombre.TabIndex = 17;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(386, 28);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(134, 20);
            this.txt_nombre.TabIndex = 16;
            // 
            // lst_Cajas
            // 
            this.lst_Cajas.FormattingEnabled = true;
            this.lst_Cajas.Location = new System.Drawing.Point(12, 12);
            this.lst_Cajas.Name = "lst_Cajas";
            this.lst_Cajas.Size = new System.Drawing.Size(237, 173);
            this.lst_Cajas.TabIndex = 15;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(273, 282);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(247, 33);
            this.btn_Eliminar.TabIndex = 14;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(273, 145);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(247, 34);
            this.btn_agregar.TabIndex = 13;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Archivos txt\"|*.txt";
            // 
            // Form_Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 327);
            this.Controls.Add(this.btn_importar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.lbl_numCaja);
            this.Controls.Add(this.txt_caja);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lst_Cajas);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Name = "Form_Caja";
            this.Text = "Cajas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label lbl_numCaja;
        private System.Windows.Forms.TextBox txt_caja;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ListBox lst_Cajas;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}