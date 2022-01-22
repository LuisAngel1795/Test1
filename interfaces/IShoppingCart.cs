using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.models;

namespace Test1.interfaces
{
     interface IShoppingCart
    {
        void agregaritem(Item item);

        string comprar();

        int ObtenerCantidadDeItems();

        decimal ObtenerTotalCompra();
    }
}
