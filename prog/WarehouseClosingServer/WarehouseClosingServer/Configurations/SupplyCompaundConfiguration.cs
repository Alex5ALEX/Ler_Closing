using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseClosingServer.Models;

namespace WarehouseClosingServer.Configurations;

public class SupplyCompaundConfiguration : IEntityTypeConfiguration<SupplyCompaund>
{
    public void Configure(EntityTypeBuilder<SupplyCompaund> builder)
    {
        builder.HasKey(c => new {c.Id_Supply, c.Id_Product });

        builder.
            HasOne(c => c.Supply)
            .WithMany(s => s.SupplyCompaunds);

        builder.
            HasOne(c => c.Product)
            .WithMany(p => p.SupplyCompaunds);
    }


}
