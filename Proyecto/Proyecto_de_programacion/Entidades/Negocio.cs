using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        int Precio;

        public Negocio()
        {

        }
        public Negocio(int Precio)
        {
            this.Precio = Precio;
        }

        public int precio { get => Precio; set => Precio = value; }
    }

}
