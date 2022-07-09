namespace CargaEquiposSeleccion
{
    partial class FrmAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcceso));
            this.BtClave = new System.Windows.Forms.Button();
            this.TxClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtClave
            // 
            this.BtClave.Location = new System.Drawing.Point(131, 133);
            this.BtClave.Name = "BtClave";
            this.BtClave.Size = new System.Drawing.Size(151, 25);
            this.BtClave.TabIndex = 2;
            this.BtClave.Text = "Ingresar";
            this.BtClave.UseVisualStyleBackColor = true;
            this.BtClave.Click += new System.EventHandler(this.BtClave_Click);
            // 
            // TxClave
            // 
            this.TxClave.Location = new System.Drawing.Point(119, 79);
            this.TxClave.Name = "TxClave";
            this.TxClave.Size = new System.Drawing.Size(163, 20);
            this.TxClave.TabIndex = 1;
            this.TxClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese la clave para acceder al formulario de carga";
            // 
            // BtCerrar
            // 
            this.BtCerrar.Location = new System.Drawing.Point(157, 211);
            this.BtCerrar.Name = "BtCerrar";
            this.BtCerrar.Size = new System.Drawing.Size(100, 25);
            this.BtCerrar.TabIndex = 3;
            this.BtCerrar.Text = "Cerrar";
            this.BtCerrar.UseVisualStyleBackColor = true;
            this.BtCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // FrmAcceso
            // 
            this.AcceptButton = this.BtClave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(415, 248);
            this.Controls.Add(this.BtCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxClave);
            this.Controls.Add(this.BtClave);
            this.Name = "FrmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese clave para acceder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtClave;
        private System.Windows.Forms.TextBox TxClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtCerrar;
    }
}