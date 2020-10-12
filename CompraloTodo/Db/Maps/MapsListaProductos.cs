using CompraloTodo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraloTodo.Db.Maps
{
    public class MapsListaProductos : IEntityTypeConfiguration<ListaProductos>
    {
        public void Configure(EntityTypeBuilder<ListaProductos> builder)
        {
            builder.ToTable("ListaProductos");
            builder.HasKey(o=>o.id);

           // builder.HasOne(o => o.Usuario).WithMany(o => o.ListaProductos).HasForeignKey(o=>o.idUsuario);
            //builder.HasOne(o => o.Producto).WithMany(o => o.ListaProductos).HasForeignKey(o=>o.idProducto);
         }
    }
}
