using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraloTodo.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public String imagen { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public int idCategoria { get; set; }
        public int idUsuario{ get; set; }

        public Categoria Categoria { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; }
        public Usuario Usuario { get; set; }
        public List<Comentarios> Comentarios { get; set; }
        public List<CarritoCompras> ProductosCarritoCompras { get; set; }
        
    }
}
