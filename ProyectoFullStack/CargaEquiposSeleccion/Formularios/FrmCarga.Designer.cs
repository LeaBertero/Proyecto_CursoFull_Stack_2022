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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarga));
            this.BtIngreso = new System.Windows.Forms.Button();
            this.LbLista = new System.Windows.Forms.Label();
            this.TxIngreso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtSalir = new System.Windows.Forms.Button();
            this.BtMostrar = new System.Windows.Forms.Button();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxAño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTFiltrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtIngreso
            // 
            this.BtIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtIngreso.Location = new System.Drawing.Point(35, 120);
            this.BtIngreso.Name = "BtIngreso";
            this.BtIngreso.Size = new System.Drawing.Size(107, 32);
            this.BtIngreso.TabIndex = 3;
            this.BtIngreso.Text = "Ingresar";
            this.BtIngreso.UseVisualStyleBackColor = true;
            this.BtIngreso.Click += new System.EventHandler(this.BtIngreso_Click_1);
            // 
            // LbLista
            // 
            this.LbLista.AutoSize = true;
            this.LbLista.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLista.Location = new System.Drawing.Point(697, 18);
            this.LbLista.Name = "LbLista";
            this.LbLista.Size = new System.Drawing.Size(157, 22);
            this.LbLista.TabIndex = 1;
            this.LbLista.Text = "Lista de convocados";
            // 
            // TxIngreso
            // 
            this.TxIngreso.Location = new System.Drawing.Point(35, 82);
            this.TxIngreso.Name = "TxIngreso";
            this.TxIngreso.Size = new System.Drawing.Size(100, 20);
            this.TxIngreso.TabIndex = 1;
            this.TxIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese los datos de los jugadores";
            // 
            // BtSalir
            // 
            this.BtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.Location = new System.Drawing.Point(35, 296);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(107, 43);
            this.BtSalir.TabIndex = 6;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // BtMostrar
            // 
            this.BtMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMostrar.Location = new System.Drawing.Point(443, 18);
            this.BtMostrar.Name = "BtMostrar";
            this.BtMostrar.Size = new System.Drawing.Size(107, 32);
            this.BtMostrar.TabIndex = 4;
            this.BtMostrar.Text = "Mostrar lista";
            this.BtMostrar.UseVisualStyleBackColor = true;
            this.BtMostrar.Click += new System.EventHandler(this.BtMostrar_Click);
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLimpiar.Location = new System.Drawing.Point(158, 120);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(107, 32);
            this.BtLimpiar.TabIndex = 5;
            this.BtLimpiar.Text = "Borrar";
            this.BtLimpiar.UseVisualStyleBackColor = true;
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Año de nacimiento";
            // 
            // TxAño
            // 
            this.TxAño.Location = new System.Drawing.Point(165, 82);
            this.TxAño.Name = "TxAño";
            this.TxAño.Size = new System.Drawing.Size(100, 20);
            this.TxAño.TabIndex = 2;
            this.TxAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre ";
            // 
            // BTFiltrar
            // 
            this.BTFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTFiltrar.Location = new System.Drawing.Point(565, 18);
            this.BTFiltrar.Name = "BTFiltrar";
            this.BTFiltrar.Size = new System.Drawing.Size(107, 32);
            this.BTFiltrar.TabIndex = 8;
            this.BTFiltrar.Text = "Filtrar";
            this.BTFiltrar.UseVisualStyleBackColor = true;
            this.BTFiltrar.Click += new System.EventHandler(this.BTFiltrar_Click);
            // 
            // FrmCarga
            // 
            this.AcceptButton = this.BtIngreso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 364);
            this.Controls.Add(this.BTFiltrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxAño);
            this.Controls.Add(this.BtLimpiar);
            this.Controls.Add(this.BtMostrar);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxIngreso);
            this.Controls.Add(this.LbLista);
            this.Controls.Add(this.BtIngreso);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTFiltrar;
    }
}

