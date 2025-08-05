using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.DTO.INPUT.Category.CreateCategoryCommand
{
    public class CreateCategoryCommand
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }

        public CreateCategoryCommand()
        {
            IsDone = flase;
            IsActive = true;
        }
    }
}
