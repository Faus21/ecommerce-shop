using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Entities.Config
{
    public class ItemEfConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(e => e.Id).HasName("Item_pk");

            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Price).HasConversion(typeof(decimal));
            

            builder.ToTable("Item");

            Item[] items =
            {
                new Item
                {
                    Id = 1,
                    Name = "Box",
                    Price = 20m
                }
            };

            builder.HasData(items);
        }
    }
}
