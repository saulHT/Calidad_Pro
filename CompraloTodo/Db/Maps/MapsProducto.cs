using CompraloTodo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraloTodo.Db.Maps
{
    public class MapsProducto : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Producto");
            builder.HasKey(o=>o.id);

            builder.HasOne(o => o.Categoria).WithMany(o => o.Productos).HasForeignKey(o => o.idCategoria);
            builder.HasOne(o => o.Usuario).WithMany(o => o.Productos).HasForeignKey(o => o.idUsuario);
        }
    }
}
