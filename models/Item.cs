using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.models
{
    class Item
    {
        public Item(string nombre, int cantidad, decimal precio)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }

        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
