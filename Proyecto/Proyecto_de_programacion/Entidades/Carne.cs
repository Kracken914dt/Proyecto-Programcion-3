using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carne
    {
        string Nombre;
        string Animal;
        string cantidad;

        public Carne()
        {

        }

        public Carne(string Nombre, int Precio, string Animal, string cantidad)
        {
            this.Nombre = Nombre;
            this.Animal = Animal;
            this.cantidad = cantidad;
        }
        public void setNombre(string Nombre) { this.Nombre = Nombre; }
        public string getNombre() {return this.Nombre;}
        public void setAnimal(string Animal) { this.Animal = Animal; }
        public string getAnimal() {return this.Animal;}
        public void setCantidad(string cantidad) { this.cantidad = cantidad; }
        public string getCantidad() {return this.cantidad;}



    }
}
