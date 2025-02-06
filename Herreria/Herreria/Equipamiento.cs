using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herreria
{
    public class Equipamiento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio_venta { get; set; }
        public string Tipo { get; set; }
        public decimal Peso { get; set; }
        public int Cantidad { get; set; }

        public Equipamiento() { }

        public Equipamiento(int id, string nombre, decimal precio_venta, string tipo, decimal peso, int cantidad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio_venta = precio_venta;
            this.Tipo = tipo;
            this.Peso = peso;
            this.Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Nombre}, Precio de Venta: {Precio_venta}, Tipo: {Tipo}, Peso: {Peso}, Cantidad: {Cantidad}";
        }
        
            
        
    }
}
