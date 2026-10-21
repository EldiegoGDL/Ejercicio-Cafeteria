using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Cafeteria
{
    public class Pedido
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public bool ParaLlevar { get; set; }
        public decimal Subtotal { get; set; }

        public Pedido(Producto producto, int cantidad, bool paraLlevar)
        {
            Producto = producto;
            Cantidad = cantidad;
            ParaLlevar = paraLlevar;
            Subtotal = producto.Precio * cantidad + (paraLlevar ? 5m : 0m); // Agregar $5 si es para llevar
        }

    }
}
