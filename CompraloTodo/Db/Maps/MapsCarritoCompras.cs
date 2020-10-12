using CompraloTodo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraloTodo.Db.Maps
{
    public class MapsCarritoCompras : IEntityTypeConfiguration<CarritoCompras>
    {
        public void Configure(EntityTypeBuilder<CarritoCompras> builder)
        {
            builder.ToTable("CarritoCompras");
            builder.HasKey(o=>o.id);

            builder.HasOne(o => o.Usuario).WithMany(o => o.CarritoCompras).HasForeignKey(o=>o.idUsuario);
            builder.HasOne(o => o.Producto).WithMany(o => o.ProductosCarritoCompras).HasForeignKey(o=>o.idProducto);
        }
    }
}
