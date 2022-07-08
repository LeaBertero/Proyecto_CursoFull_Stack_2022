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
        public ListaJugadores Lista { get; set; } = new ListaJugadores();

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
            //Jugadores persona = new Jugadores(); //Instanciar/inicializar un objeto, en este caso la clase persona
            
            //persona.Nombre = TxIngreso.Text; //Creando propiedades de la instancia persona

            //persona.Edad = Convert.ToInt32(TxAño.Text);
            
            //Lista.Redimensionar(); //LLamo al metodo en el boton de ingreso

            //Lista.personas[Lista.personas.Length -1] = persona;
            
            //TxIngreso.SelectAll(); //Métodos de la caja de texto
            
            //TxIngreso.Focus();
        }
        private void BtMostrar_Click(object sender, EventArgs e)
        {
            LbLista.Text = "Lista de personas \r\n";
            foreach (Jugadores Pers in Lista.personas)
            {
                LbLista.Text = LbLista.Text + "Nombre: " + Pers.Nombre + " - " + " Edad: " + Pers.Edad.ToString() + "\r\n" + "\r\n";
            }
        }
        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            LbLista.Text = null;
        }
    }  
} 
       
        



       

        
        


       
       
        

            
            
       
       
       


            

            






        






        
        

        

       
        






        






                


        





        
