using Microsoft.EntityFrameworkCore;
using TodoApp.Domain.Entities.Categories;
using TodoApp.Domain.Entities.Items;

namespace TodoApp.Infrastructure.Context.SqlServer
{
    public class TodoDBContext: DbContext
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> options) : base(options)
        {
        }

        public DbSet<Item> Items {  get; set; }
        public DbSet<Category> Categories {  get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TodoDBContext).Assembly);
        }
    }
}
