using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herreria
{
    public class MateriaPrima
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Peso { get; set; }
        public decimal Precio_compra { get; set; }

        public MateriaPrima() { }

        public MateriaPrima(int id, string nombre, decimal peso, decimal precio_compra)
        {
            Id = id;
            Nombre = nombre;
            Peso = peso;
            this.Precio_compra = precio_compra;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Nombre}, Peso: {Peso}, Precio de Compra: {Precio_compra}";
        }

    }
}
