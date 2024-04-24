using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUno.Models
{
    internal class Bebida
    {
        public string nombre {  get; set; }
        public int cantidad {  get; set; }

        /*  {
            get { return _nombre; }
            set { _nombre = value; }
        }*/

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public Bebida(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }

        public void tomarse(int cuantoBebio)
        {
            this.cantidad -= cuantoBebio;
        }
    }
}
