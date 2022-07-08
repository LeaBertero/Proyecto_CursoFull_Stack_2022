using CargaEquiposSeleccion.Clases; //using agregado de la ruta de archivos de la clase persona
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
    public partial class FrmCarga : Form //Form1 Hereda de Form
    {
        public ListaPersonas Lista { get; set; } = new ListaPersonas();

        public FrmCarga()
        {
            InitializeComponent(); 
        }
        
        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtIngreso_Click_1(object sender, EventArgs e)
        {
            Lista.AddPersona(TxIngreso.Text, TxAño.Text);
        }
        private void BtMostrar_Click(object sender, EventArgs e)
        {
            LbLista.Text = Lista.ToString();
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            LbLista.Text = null;
        }
    }  
} 
            



       
       
        



       

        
        


       
       
        

            
            
       
       
       


            

            






        






        
        

        

       
        






        






                


        





        
