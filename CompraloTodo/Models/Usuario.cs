using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraloTodo.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string rol { get; set; }

        public List<Producto> Productos { get; set; } 
        public List<Venta> Ventas { get; set; }
        public List<CarritoCompras> CarritoCompras { get; set; }
        public List<Comentarios> Comentarios { get; set; }
    }
}
