using System;
using CarritoDeCompras.Properties;

namespace CarritoDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {

            Camisas miCamisa = new Camisas();
            Carrito miCarrito = new Carrito();
            Menu miMenu = new Menu();
            
            miMenu.mostrarMenu(miCamisa,miCarrito);

        }
    }
}
