namespace CargaEquiposSeleccion
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // BtIngreso
            // 
            this.BtIngreso.Location = new System.Drawing.Point(193, 250);
            this.BtIngreso.Name = "BtIngreso";
            this.BtIngreso.Size = new System.Drawing.Size(230, 116);
            this.BtIngreso.TabIndex = 0;
            this.BtIngreso.Text = "Ingresar";
            this.BtIngreso.UseVisualStyleBackColor = true;
            this.BtIngreso.Click += new System.EventHandler(this.BtIngreso_Click);
            // 
            // LbLista
            // 
            this.LbLista.AutoSize = true;
            this.LbLista.Location = new System.Drawing.Point(51, 171);
            this.LbLista.Name = "LbLista";
            this.LbLista.Size = new System.Drawing.Size(98, 13);
            this.LbLista.TabIndex = 1;
            this.LbLista.Text = "Lista de ingresados";
            // 
            // TxIngreso
            // 
            this.TxIngreso.Location = new System.Drawing.Point(49, 95);
            this.TxIngreso.Name = "TxIngreso";
            this.TxIngreso.Size = new System.Drawing.Size(100, 20);
            this.TxIngreso.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese aquí los datos a cargar";
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(715, 401);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(146, 67);
            this.BtSalir.TabIndex = 4;
            this.BtSalir.Text = "Cerrar Programa";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // BtMostrar
            // 
            this.BtMostrar.Location = new System.Drawing.Point(449, 250);
            this.BtMostrar.Name = "BtMostrar";
            this.BtMostrar.Size = new System.Drawing.Size(230, 116);
            this.BtMostrar.TabIndex = 5;
            this.BtMostrar.Text = "Mostrar";
            this.BtMostrar.UseVisualStyleBackColor = true;
            this.BtMostrar.Click += new System.EventHandler(this.BtMostrar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BtIngreso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(873, 480);
            this.Controls.Add(this.BtMostrar);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxIngreso);
            this.Controls.Add(this.LbLista);
            this.Controls.Add(this.BtIngreso);
            this.MaximizeBox = false;
            this.Name = "Form1";
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
    }
}

