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
        public string ToStringFiltrado(int añominimo)
        {
            string Resp = null;

            Resp = "Lista de personas \r\n";
            foreach (Personas Ind in personas)
            {
                if (Ind.AñoNacimiento >= añominimo)
                {
                    Resp = Resp + Ind.AñoNacimiento.ToString() + " - " + Ind.Nombre + "\r\n";
                }

                Resp = Resp + "Nombre: " + Ind.Nombre + " - " + " Año de nacimiento: " + Ind.AñoNacimiento.ToString() + "\r\n" + "\r\n";
            }

            return Resp;
        }

        public bool AddPersona(string Nombre, string Año)
        {
            Personas persona = new Personas(); //Instanciar/inicializar un objeto, en este caso la clase persona
            persona.Nombre = Nombre; //Creando propiedades de la instancia persona
            persona.AñoNacimiento = Convert.ToInt32(Año);
            bool respuesta = persona.Validar();

            if (respuesta)
            {
                Redimensionar(); //LLamo al metodo en el boton de ingreso
                personas[personas.Length - 1] = persona;
            }
            return respuesta;

        }
    }
}
            













            


