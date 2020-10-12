using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraloTodo.Models
{
    public class Venta
    {
        public int id { get; set; }
        public int idUsuario { get; set; }
        public Decimal montoTotal { get; set; }
        public byte TipoPago { get; set; }

        public Usuario Usuario { get; set; }
        public List<DetalleVenta> DetalleVenta { get; set; }

    }
}
