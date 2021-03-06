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
            //LbLista.Text = "";

            if (!Lista.AddPersona(TxIngreso.Text, TxAño.Text)) 
            {
                
                TxAño.SelectAll();
                TxIngreso.Text = null;
                TxIngreso.Focus();
                LbLista.Text = "Persona no valida";
            }
            else
            {
                TxAño.Text = null;
                TxIngreso.Text = null;
                TxIngreso.Focus();
                LbLista.Text = "Persona Valida";
            }
        }

        private void BtMostrar_Click(object sender, EventArgs e)
        {
            LbLista.Text = Lista.ToString();
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            LbLista.Text = null;
        }

        private void BTFiltrar_Click(object sender, EventArgs e)
        {
            LbLista.Text = Lista.ToStringFiltrado(2000);
        }
    }  
} 


            


            

           


            



       
       
        



       

        
        


       
       
        

            
            
       
       
       


            

            






        






        
        

        

       
        






        






                


        





        
