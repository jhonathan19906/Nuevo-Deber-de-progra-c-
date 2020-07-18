using System;
using System.Collections.Generic;
using System.Text;

namespace DeberDelViernes
{
    class Pelota : Producto
    {
        public float Precio { get; set; }
        public Pelota() : base()
        {

        }
        public string Nueva()
        {
            return $"numero de la pelota{Id} {this.Marca} {this.Modelo} {this.Precio}";
        }
    }
}
