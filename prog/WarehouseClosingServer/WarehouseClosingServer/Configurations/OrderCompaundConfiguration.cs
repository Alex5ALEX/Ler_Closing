using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseClosingServer.Models;

namespace WarehouseClosingServer.Configurations;

public class OrderCompaundConfiguration : IEntityTypeConfiguration<OrderCompaund>
{

    public void Configure(EntityTypeBuilder<OrderCompaund> builder)
    {
        builder.HasKey(o => new { o.Id_Order, o.Id_Product });

        builder.HasOne(o => o.Order)
            .WithMany(o => o.OrderCompaunds);

        builder.HasOne(o => o.Product)
            .WithMany(p => p.OrderCompaunds);
    }
}
