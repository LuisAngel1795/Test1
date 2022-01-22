using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.interfaces;

namespace Test1.models
{
    class ShoppingCart : IShoppingCart
    {
        public DateTime FechaDeCompra { get; set; }
        public List<Item> ListaDeItems { get; set; }
        public decimal TotalDeCompra { get; set; }

        public ShoppingCart()
        {
            ListaDeItems = new List<Item>();
        }

        public void agregaritem(Item item)
        {
            ListaDeItems.Add(item);
        }

        public string comprar()
        {
            TotalDeCompra = ObtenerTotalCompra();
            FechaDeCompra = DateTime.Now;

            return ToString();
        }

        public int ObtenerCantidadDeItems()
        {
            return ListaDeItems.Count();
        }

        public decimal ObtenerTotalCompra()
        {
            TotalDeCompra = 0;
            foreach (Item i in ListaDeItems)
            {
                TotalDeCompra += i.Precio * i.Cantidad;
            }
            return TotalDeCompra;
        }
        
        public override string ToString()
        {
            return "Se compraron un total de "+ListaDeItems.Count + " y fue un total de $"+TotalDeCompra+"\n Fecha: "+FechaDeCompra;
        }
    }
}
