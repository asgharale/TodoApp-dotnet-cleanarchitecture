using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities.Items.Item;

namespace TodoApp.Domain.Entities.Categories
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Item> Items { get; set; } = new List<Item()>;
    }
}
