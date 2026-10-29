using G_NET68_EF_Assignment_1.Contexts;
using Microsoft.EntityFrameworkCore;

namespace G_NET68_EF_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using BookInventoryDbContext db = new BookInventoryDbContext();
            db.Books.Add(new Models.Book { Title = "Clean Code", NumberOfPages = 1000, PublicationYear = 2026 ,ISBNNumber = "9780132350884" });
            db.SaveChanges();
        }
    }
}
