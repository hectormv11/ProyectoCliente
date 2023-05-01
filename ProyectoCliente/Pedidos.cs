using System;
using System.Collections.Generic;
using System.Text;
using productos;
using usuarios;

namespace ProyectoCliente
{
    public class Pedidos
    {
        public int NºPedido;
        public DateTime fecha;
        public List<Producto> productosDelPedido;
        public int cantidad;
        public float precioFinal;
        public string cliente;
    }
    
}
