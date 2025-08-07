using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.Contracts.INPUT.Category.CreateCategory
{
    public class CreateCategoryCommand
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        
        public CreateCategoryCommand()
        {
            IsActive = true;
        }
    }
}
