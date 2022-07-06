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
        //Cuando se genere error y no reconozca la clase, se puede evitar de dos maneras
        //Bien poniendo la ruta de donde se encuentran los archivos,(Poner la rutra del NameSpace)
        //o bien hacer control + punto y automaticamente encuentra la ruta

        //Arreglo de personas, para realizar la carga en el proyecto
        public Jugadores[] personas { get; set; }

        //Constructor del formulario -> aca es donde empieza a ejecutar el programa

       
        public FrmCarga()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtIngreso_Click(object sender, EventArgs e)
        {
            //Métodos de la caja de texto
            TxIngreso.SelectAll();
            TxIngreso.Focus();

            //Instanciar un objeto, en este caso la clase persona
            Jugadores persona = new Jugadores();

            //Creando propiedades de la instancia persona
            persona.persona = TxIngreso.Text;

            Redimensionar();

            //Propiedad "Personas" - Instancia "persona"
            //Personas.Leng(longitud de personas)

            personas[personas.Length -1] = persona;
        }
            


        private void BtMostrar_Click(object sender, EventArgs e)
        {
            LbLista.Text = "Lista de personas \r\n";
            foreach (Jugadores Cantidad in personas)
            {
                LbLista.Text = LbLista.Text + " " + Cantidad.persona + "\r\n";
            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            LbLista.Text = null;
        }

        private void Redimensionar()
        {
            if (personas == null)
            {
                personas = new Jugadores[1];
            }
            else
            {
                Jugadores[] ArregloAuxiliar = new Jugadores[personas.Length +1];

                for (int incremento = 0; incremento < personas.Length + 1; incremento++)
                {
                    ArregloAuxiliar[incremento] = personas[incremento];

                    personas = ArregloAuxiliar;
                }

            }
        }
    }  
} 





        
