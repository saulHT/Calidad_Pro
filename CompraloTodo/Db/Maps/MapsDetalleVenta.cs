using CompraloTodo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraloTodo.Db.Maps
{
    public class MapsDetalleVenta : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("DetalleVenta");
            builder.HasKey(o=>o.id);

            builder.HasOne(o => o.Venta).WithMany(o => o.DetalleVenta).HasForeignKey(o=>o.idVenta);
            builder.HasOne(o => o.Producto).WithMany(o => o.DetalleVentas).HasForeignKey(o=>o.idProducto);
        }
    }
}
