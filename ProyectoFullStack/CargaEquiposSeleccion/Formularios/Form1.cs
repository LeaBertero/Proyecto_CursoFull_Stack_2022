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
    public partial class Form1 : Form //Form1 Hereda de Form
    {
        //Cuando se genere error y no reconozca la clase, se puede evitar de dos maneras
        //Bien poniendo la ruta de donde se encuentran los archivos,(Poner la rutra del NameSpace)
        //o bien hacer control + punto y automaticamente encuentra la ruta

        //Arreglo de personas, para realizar la carga en el proyecto
        public Persona[] persona { get; set; } //Propiedades de la persona

        //Constructor del formulario -> aca es donde empieza a ejecutar el programa
        public Form1()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtIngreso_Click(object sender, EventArgs e)
        {
            //Instanciar un objeto, en este caso la clase persona
            Persona persona = new Persona();    


        }
    }
}

        
