using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaEquiposSeleccion.Clases
{
    public class ListaPersonas
    {
        public Personas[] personas { get; set; }
        public void Redimensionar()
        {
            if (personas == null)
            {
                personas = new Personas[1];
            }
            else
            {
                Personas[] ArrNew = new Personas[personas.Length + 1];
                for (int AddPers = 0; AddPers < personas.Length; AddPers++)
                {
                    ArrNew[AddPers] = personas[AddPers];
                }
                personas = ArrNew;
            }
        }
        public override string ToString()
        {
            string Resp = null;

            Resp = "Lista de personas \r\n";
            foreach (Personas Pers in personas)
            {
                Resp = Resp + "Nombre: " + Pers.Nombre + " - " + " Edad: " + Pers.Edad.ToString() + "\r\n" + "\r\n";
            }

            return Resp;
        }
        public void AddPersona(string Nombre, string Año)
        {
            Personas persona = new Personas(); //Instanciar/inicializar un objeto, en este caso la clase persona
            persona.Nombre = Nombre; //Creando propiedades de la instancia persona
            persona.Edad = Convert.ToInt32(Año);
            Redimensionar(); //LLamo al metodo en el boton de ingreso
            personas[personas.Length -1] = persona;
        }
    }
}












            


