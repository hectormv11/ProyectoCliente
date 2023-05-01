using System;
using System.Collections.Generic;
using System.Text;

namespace productos
{
    public class Producto
    {
        public int id;
        public string marca;
        public string nombre;
        public string descripcion;
        public float precioBase;
        public float descuento;
        private string categoria;
        public List<string> etiquetas;
        public List<string> reseñas;

        private bool cesta()
        {
            return true;
        }
    }

    public class carrito : Producto
    {
        public int NºdeProductos;
        public string productos;
        public float precioTotalCesta;
    }
}
