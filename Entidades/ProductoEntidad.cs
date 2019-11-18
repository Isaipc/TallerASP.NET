using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerASP.NET.Entidades
{
    public class ProductoEntidad
    {
        public string id;
        public string nombre;
        public float precio;
        public int stock;

        public ProductoEntidad() { }

        public ProductoEntidad(string id, string nombre, float precio, int stock)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

    }
}