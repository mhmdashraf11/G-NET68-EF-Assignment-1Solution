using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_1.Models
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string Discreption { get; set; } = null!;
        public bool IsActive { get; set; } 



    }
}
