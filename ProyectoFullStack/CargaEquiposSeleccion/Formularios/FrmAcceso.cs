using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargaEquiposSeleccion
{
    public partial class FrmAcceso : Form
    {
        public FrmAcceso()
        {
            InitializeComponent();
        }

        private void BtClave_Click(object sender, EventArgs e)
        {
            if (TxClave.Text == "clave22")
            {

                MessageBox.Show("Ingreso correcto");

                FrmCarga SegundoForm = new FrmCarga();
                SegundoForm.ShowDialog();

            }
            if (TxClave.Text == "")
            {
                MessageBox.Show("Debe ingresar una clave valida");
                
            }
            if (TxClave.Text != "clave22")
            {
                MessageBox.Show("Ingreso incorrecto");
            }
        }
    }
}
        


            

