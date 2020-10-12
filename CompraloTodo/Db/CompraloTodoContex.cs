using CompraloTodo.Db.Maps;
using CompraloTodo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraloTodo.Db
{
    public class CompraloTodoContex:DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }
        public DbSet<DetalleVenta> detalleVentas { get; set; }
        public DbSet<ListaProductos>listaProductos  { get; set; }
        public DbSet<Venta>ventas  { get; set; }
        public DbSet<CarritoCompras>CarritoCompras  { get; set; }
        

        public CompraloTodoContex(DbContextOptions<CompraloTodoContex> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MapsUsuario());
            modelBuilder.ApplyConfiguration(new MapsCategoria());
            modelBuilder.ApplyConfiguration(new MapsProducto());
            modelBuilder.ApplyConfiguration(new MapsComentario());
            modelBuilder.ApplyConfiguration(new MapsDetalleVenta());
            modelBuilder.ApplyConfiguration(new MapsListaProductos());
            modelBuilder.ApplyConfiguration(new MapsVenta()); 
            modelBuilder.ApplyConfiguration(new MapsCarritoCompras()); 
        }
    }
}
