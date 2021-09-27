using System;
using System.Security.AccessControl;

namespace CarritoDeCompras.Properties
{
    public class Menu
    {
        private int opcion; //guarda la opcion que elijamos del menu
        private bool repite = true; //booleano para poder volver al programa cuando quise salir pero no confirme salida

        public void mostrarMenu(Camisas camisa, Carrito carrito)
        {
            do
            {
                carrito.CalcuilarTotal(camisa.precioUnidad());
                carrito.Descuento();

                Console.Clear();
                Console.WriteLine("\nSHOPPING ONLINE DE CAMISAS - Ventas minoristas y mayoristas");
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("\nMENU PRINCIPAL: ");
                Console.WriteLine("\n1. Añadir camisa al carro de compras");
                Console.WriteLine("\n2. Eliminar camisa del carro de compras");
                Console.WriteLine("\n3. Salir");
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine(
                    $"\n              -   Cantidad de camisas en el carro de compras: {carrito.Cantidad}");
                Console.WriteLine("\n              -   Precio Unitario: $1000");
                Console.WriteLine("\n              -   Precio total sin descuento: $" + carrito.Precio);
                Console.WriteLine("\n              -   Tipo de descuento aplicado: %" + carrito.PorcentajeAplicado);
                Console.WriteLine("\n              -   Precio final con descuento: $" + carrito.PrecioTotal);
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("Ingrese una opcion del menu:");
                opcion = int.Parse(Console.ReadLine()); // convierto lo leido en int
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        carrito.Cantidad += 1;
                        break;
                    case 2:
                        carrito.Cantidad -= 1;
                        break;
                    case 3:
                        Console.Clear(); //limpio consola 
                        Console.WriteLine("\nEsta seguro de salir? 'S' para si / 'N' para no");
                        string salida = Console.ReadLine();
                        if (salida == "S")
                        {
                            Console.WriteLine("Cerrando programa");
                            repite = false; //finaliza el programa
                        }
                        else
                        {
                            opcion = 0;
                        }
                        break;
                }
            } while (opcion != 3);

        }
    }
}