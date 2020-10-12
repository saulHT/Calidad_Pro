using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraloTodo.Models
{
    public class DetalleVenta
    {
        public int id { get; set; }
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public Decimal PrecioUnitario { get; set; }

        public Venta Venta { get; set; }
        public Producto Producto { get; set; }
    }
}
