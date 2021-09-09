using System;

namespace CarritoDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repite = true; //booleano para poder volver al programa cuando quise salir pero no confirme salida
            int opcion; //guarda la opcion que elijamos del menu
            float cantidad = 0, porcentajeAplicado = 0; 
            double precio = 0, precioFinal = 0, por=0 ;

            do
            {
                Console.Clear();
                Console.WriteLine("\nSHOPPING ONLINE DE CAMISAS - Ventas minoristas y mayoristas");
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("\nMENU PRINCIPAL: ");
                Console.WriteLine("\n1. Añadir camisa al carro de compras");
                Console.WriteLine("\n2. Eliminar camisa del carro de compras");
                Console.WriteLine("\n3. Salir");
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine($"\n              -   Cantidad de camisas en el carro de compras: {cantidad}");
                Console.WriteLine("\n              -   Precio Unitario: $1000");
                Console.WriteLine("\n              -   Precio total sin descuento: $" + precio);
                Console.WriteLine("\n              -   Tipo de descuento aplicado: %" + porcentajeAplicado);
                Console.WriteLine("\n              -   Precio final con descuento: $" + precioFinal);
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("Ingrese una opcion del menu:");
                opcion=int.Parse(Console.ReadLine()); // convierto lo leido en int
                Console.Clear(); 

                switch (opcion)
                {
                    case 1:
                        cantidad += 1;
                        break;
                    case 2:
                        cantidad -= 1;
                        break;
                    case 3:
                        Console.Clear();    //limpio consola 
                        Console.WriteLine("\nEsta seguro de salir? 'S' para si / 'N' para no");
                        string salida =Console.ReadLine();
                         if (salida == "S")
                         {
                             repite = false; //finaliza el programa
                         }
                        Console.Clear();
                        break;
                }

                if (cantidad >= 3 && cantidad <=5) //if de descuento para 3 y 5 camisas
                {
                    porcentajeAplicado = 10;
                    por=0.1;
                }

                if (cantidad > 5) //if de descuento para mas de 6 camisas
                {
                    porcentajeAplicado = 20;
                    por=0.2;
                }

                precio = cantidad * 1000; 
                precioFinal = precio - (precio * por); //resto el porcentaje de descuento al precio sin descuento
                Console.Clear();
            } while (repite);















        }
    }
}
