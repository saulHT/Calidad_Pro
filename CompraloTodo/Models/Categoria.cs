using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraloTodo.Models
{
    public class Categoria
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
