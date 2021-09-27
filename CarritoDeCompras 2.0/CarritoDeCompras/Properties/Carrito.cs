namespace CarritoDeCompras.Properties
{
    public class Carrito
    {
        private int cantidad=0;
        private double precio;
        private double precioTotal;
        private float porcentajeAplicado;
        private double por;

        public void CalcuilarTotal(double unidad)
        {
            precio = cantidad * unidad;
        }

        public void Descuento()
        {
            if (cantidad >= 3 && cantidad <=5) //if de descuento para 3 y 5 camisas
            {
                porcentajeAplicado = 10;
                por=0.1;
            } 
            else if (cantidad > 5)
            {
                porcentajeAplicado = 20;
                por = 0.2;
            }
            else
            {
                porcentajeAplicado = 0;
                por = 0;
            }
            
            precioTotal = precio - (precio * por);
 
            
        }
        

        public double Precio
        {
            get => precio;
            set => precio = value;
        }

        public double PrecioTotal
        {
            get => precioTotal;
            set => precioTotal = value;
        }

        public float PorcentajeAplicado
        {
            get => porcentajeAplicado;
            set => porcentajeAplicado = value;
        }

        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }
    }
}