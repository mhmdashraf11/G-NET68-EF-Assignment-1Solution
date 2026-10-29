using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_1.Models
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public string ISBNNumber { get; set; } = null!; 
        public int NumberOfPages { get; set; }
        public int PublicationYear { get; set; }
        public bool IsInStock { get; set; }

    }
}
