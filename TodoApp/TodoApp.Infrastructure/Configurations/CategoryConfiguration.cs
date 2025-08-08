using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoApp.Domain.Entities.Categories;

namespace TodoApp.Infrastructure.Configurations
{
    public class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Description).HasMaxLength(255);


            // some test data
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Work",
                    Description = "Tasks related to job and career",
                    IsActive = true
                },
                new Category
                {
                    Id = 2,
                    Name = "hello",
                    Description = " to job and career",
                    IsActive = false
                },
                new Category
                {
                    Id = 3,
                    Name = "Day",
                    Description = "bye hye bye Tasks related to job and career",
                    IsActive = true
                }
                );
        }
    }
}
