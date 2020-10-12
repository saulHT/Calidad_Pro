using CompraloTodo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraloTodo.Db.Maps
{
    public class MapsComentario : IEntityTypeConfiguration<Comentarios>
    {
        public void Configure(EntityTypeBuilder<Comentarios> builder)
        {
            builder.ToTable("Comentarios");
            builder.HasKey(o=>o.id);

            builder.HasOne(o => o.Producto).WithMany(o => o.Comentarios).HasForeignKey(o=>o.idProducto);
            builder.HasOne(o=>o.Usuario).WithMany(o=>o.Comentarios).HasForeignKey(o=>o.idUsuario);
        }
    }
}
