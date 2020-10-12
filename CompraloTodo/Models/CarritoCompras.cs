using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraloTodo.Models
{
    public class CarritoCompras
    {
        public int id { get; set; }
        public int idProducto { get; set; }
        public int idUsuario { get; set; }
        public int cantidad { get; set; }

        public Producto Producto { get; set; }
        public Usuario Usuario { get; set; }

    }
}
