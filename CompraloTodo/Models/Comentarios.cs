using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraloTodo.Models
{
    public class Comentarios
    {
        public int id { get; set; }
        public string texto { get; set; }
        public DateTime fecha { get; set; }
       
        public int idUsuario { get; set; }
        public int idProducto { get; set; }

        public Producto Producto { get; set; }
        public Usuario Usuario { get; set; }
    }
}
