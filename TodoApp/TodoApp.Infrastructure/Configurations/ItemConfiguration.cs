using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoApp.Domain.Entities.Items;

namespace TodoApp.Infrastructure.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(255);
            builder.Property(e => e.Description).HasMaxLength(500);
            builder.Property(e => e.IsDone).IsRequired();
            builder.Property(e => e.DueDate).IsRequired(false);
            builder.Property(e => e.CreatedAt).IsRequired(false);
            builder.Property(e => e.UpdatedAt).IsRequired(false);
            builder.Property(e => e.IsActive).IsRequired(false);
            builder.HasOne(e => e.Category)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);


            // some sample data
            builder.HasData(
                new Item
                {
                    Id = 1,
                    Name = "Finish report",
                    Description = "Complete the financial report",
                    IsDone = false,
                    DueDate = DateTime.Now.AddDays(2),
                    IsActive = true,
                    CategoryId = 1,
                    CreatedAt = DateTime.Now.AddDays(-1),
                    UpdatedAt = DateTime.Now
                },
                new Item
                {
                    Id = 2,
                    Name = "hello",
                    Description = "Complete the sasfoasjhaih report",
                    IsDone = true,
                    DueDate = DateTime.Now,
                    IsActive = true,
                    CategoryId = 1,
                    CreatedAt = DateTime.Now.AddDays(-1),
                    UpdatedAt = DateTime.Now
                },
                new Item
                {
                    Id = 1,
                    Name = "Finish report",
                    Description = "Complete the financial report",
                    IsDone = false,
                    DueDate = DateTime.Now.AddDays(2),
                    IsActive = false,
                    CategoryId = 1,
                    CreatedAt = DateTime.Now.AddDays(-1),
                    UpdatedAt = DateTime.Now
                }
                );
        }
    }
}
