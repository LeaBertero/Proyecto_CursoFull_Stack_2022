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
        //Arreglo de personas, para realizar la carga en el proyecto
        public Jugadores[] personas { get; set; } = new Jugadores[3];

        public int posicion = -1;

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
            //Métodos de la caja de texto
            TxIngreso.SelectAll();
            TxIngreso.Focus();

            //Instanciar un objeto, en este caso la clase persona
            Jugadores persona = new Jugadores();

            posicion = posicion + 1;

            //Creando propiedades de la instancia persona
            persona.Nombre = TxIngreso.Text;

            persona.Edad = Convert.ToInt32(TxAño.Text);

            personas[posicion] = persona;

            //Redimensionar();

            //Propiedad "Personas" - Instancia "persona"
            //Personas.Leng(longitud de personas)

            personas[personas.Length - 1] = persona;
        }

        private void BtMostrar_Click(object sender, EventArgs e)
        {
            LbLista.Text = "Lista de personas \r\n";
            foreach (Jugadores Pers in personas)
            {
                LbLista.Text = LbLista.Text + "Nombre: " + Pers.Nombre + " - " + " Edad: " + Pers.Edad.ToString() + "\r\n" + "\r\n";
            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            LbLista.Text = null;
        }

        //private void Redimensionar()
        //{
        //    if (personas == null)
        //    {
        //        personas = new Jugadores[1];
        //    }
        //    else
        //    {
        //        Jugadores[] ArregloAuxiliar = new Jugadores[personas.Length + 1];

        //        for (int incremento = 0; incremento < personas.Length + 1; incremento++)
        //        {
        //            ArregloAuxiliar[incremento] = personas[incremento];

        //            personas = ArregloAuxiliar;
        //        }
        //    }
        //}
        
    }  
} 
        

        

       
        






        






                


        





        
