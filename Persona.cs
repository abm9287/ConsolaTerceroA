using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolaTerceroA
{
    class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Saludar(string Nombre)
        {
            return "Hola " + Nombre + " me llamo" + this.Nombre;
        }

        public void WriteLine(string dato)
        {

        }
    }
}


