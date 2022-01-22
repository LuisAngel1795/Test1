using System;
using Test1.models;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Item i1 = new Item("item1", 3, 15);
            Item i2 = new Item("item2", 4, 12);
            Item i3 = new Item("item3", 2, 13);


            ShoppingCart carrito = new ShoppingCart();


            carrito.agregaritem(i1);

            Console.WriteLine(carrito.ObtenerCantidadDeItems()+"\n");

            Console.WriteLine(carrito.ObtenerTotalCompra()+"\n");

            carrito.agregaritem(i2);

            Console.WriteLine(carrito.ObtenerCantidadDeItems()+"\n");

            Console.WriteLine(carrito.ObtenerTotalCompra()+"\n");

            carrito.agregaritem(i3);

            Console.WriteLine(carrito.ObtenerCantidadDeItems()+"\n");

            Console.WriteLine(carrito.ObtenerTotalCompra()+"\n");

            Console.WriteLine(carrito.comprar());
        }
    }
}
