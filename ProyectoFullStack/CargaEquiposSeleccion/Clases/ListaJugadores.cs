using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaEquiposSeleccion.Clases
{
    public class ListaJugadores
    {
        public Jugadores[] personas { get; set; }

        public void Redimensionar()
        {
            if (personas == null)
            {
               personas = new Jugadores[1];
            }
            else
            {
                Jugadores[] ArrNew = new Jugadores[personas.Length + 1];

                for (int AddPers = 0; AddPers < personas.Length; AddPers++)
                {
                    ArrNew[AddPers] = personas[AddPers];
                }

                personas = ArrNew;
            }
        }

    }

}
