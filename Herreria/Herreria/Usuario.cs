using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herreria
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string password { get; set; }
        public string rol { get; set; }

        public Usuario(string nombre, string password, string rol)
        {
            this.nombre = nombre;
            this.password = password;
            this.rol = rol;
        }
        public Usuario()
        {
            this.nombre = "";
            this.password = "";
            this.rol = "";
        }





    }
}
