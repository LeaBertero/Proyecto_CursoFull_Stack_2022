using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaEquiposSeleccion.Clases
{
    //Clases
    public class Personas
    {
        //Propiedades de la clase (Persona)
        public string Nombre { get; set; }
        public int AñoNacimiento { get; set; }

        public bool Validar()
        {
            bool respuesta = false;

            if (AñoNacimiento > 1900 && AñoNacimiento <= DateTime.Now.Year)
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}

               

           






