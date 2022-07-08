namespace CargaEquiposSeleccion
{
    partial class FrmCarga
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
            this.BtIngreso = new System.Windows.Forms.Button();
            this.LbLista = new System.Windows.Forms.Label();
            this.TxIngreso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtSalir = new System.Windows.Forms.Button();
            this.BtMostrar = new System.Windows.Forms.Button();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxAño = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtIngreso
            // 
            this.BtIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtIngreso.Location = new System.Drawing.Point(262, 26);
            this.BtIngreso.Name = "BtIngreso";
            this.BtIngreso.Size = new System.Drawing.Size(155, 47);
            this.BtIngreso.TabIndex = 0;
            this.BtIngreso.Text = "Ingresar jugador";
            this.BtIngreso.UseVisualStyleBackColor = true;
            this.BtIngreso.Click += new System.EventHandler(this.BtIngreso_Click_1);
            // 
            // LbLista
            // 
            this.LbLista.AutoSize = true;
            this.LbLista.Location = new System.Drawing.Point(487, 26);
            this.LbLista.Name = "LbLista";
            this.LbLista.Size = new System.Drawing.Size(147, 13);
            this.LbLista.TabIndex = 1;
            this.LbLista.Text = "Lista de jugadores ingresados";
            // 
            // TxIngreso
            // 
            this.TxIngreso.Location = new System.Drawing.Point(35, 54);
            this.TxIngreso.Name = "TxIngreso";
            this.TxIngreso.Size = new System.Drawing.Size(100, 20);
            this.TxIngreso.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese aquí los juegadores a cargar";
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(35, 238);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(99, 44);
            this.BtSalir.TabIndex = 4;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // BtMostrar
            // 
            this.BtMostrar.Location = new System.Drawing.Point(262, 79);
            this.BtMostrar.Name = "BtMostrar";
            this.BtMostrar.Size = new System.Drawing.Size(155, 47);
            this.BtMostrar.TabIndex = 1;
            this.BtMostrar.Text = "Mostrar jugador";
            this.BtMostrar.UseVisualStyleBackColor = true;
            this.BtMostrar.Click += new System.EventHandler(this.BtMostrar_Click);
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Location = new System.Drawing.Point(262, 132);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(155, 47);
            this.BtLimpiar.TabIndex = 2;
            this.BtLimpiar.Text = "Borrar lista cargada";
            this.BtLimpiar.UseVisualStyleBackColor = true;
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edad";
            // 
            // TxAño
            // 
            this.TxAño.Location = new System.Drawing.Point(35, 121);
            this.TxAño.Name = "TxAño";
            this.TxAño.Size = new System.Drawing.Size(100, 20);
            this.TxAño.TabIndex = 5;
            // 
            // FrmCarga
            // 
            this.AcceptButton = this.BtIngreso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(719, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxAño);
            this.Controls.Add(this.BtLimpiar);
            this.Controls.Add(this.BtMostrar);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxIngreso);
            this.Controls.Add(this.LbLista);
            this.Controls.Add(this.BtIngreso);
            this.MaximizeBox = false;
            this.Name = "FrmCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga Jugadores Seleccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtIngreso;
        private System.Windows.Forms.Label LbLista;
        private System.Windows.Forms.TextBox TxIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Button BtMostrar;
        private System.Windows.Forms.Button BtLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxAño;
    }
}

