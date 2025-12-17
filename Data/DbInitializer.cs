using Microsoft.EntityFrameworkCore;
using Porumb_Denisa_Lab2.Models;
using System.Linq;

namespace Porumb_Denisa_Lab2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Porumb_Denisa_Lab2Context
                (serviceProvider.GetRequiredService
                   <DbContextOptions<Porumb_Denisa_Lab2Context>>()))
            {
                if (context.Book.Any())
                {
                    return;   // BD a fost creata anterior                 } 
                } 
                var authors = new Author[]
                    {
                    new Author { FirstName = "Mihail", LastName = "Sadoveanu" },
                    new Author { FirstName = "George", LastName = "Calinescu" },
                    new Author { FirstName = "Mircea", LastName = "Eliade" }
                    };
                context.Author.AddRange(authors);
                context.SaveChanges();

                context.Book.AddRange(
                    new Book { Title = "Baltagul", AuthorID = authors.Single(a => a.LastName == "Sadoveanu").ID, Price = Decimal.Parse("22") },
                    new Book { Title = "Enigma Otiliei", AuthorID = authors.Single(a => a.LastName == "Calinescu").ID, Price = Decimal.Parse("18") },
                    new Book { Title = "Maytrei", AuthorID = authors.Single(a => a.LastName == "Eliade").ID, Price = Decimal.Parse("27") }
                    );


                context.Genre.AddRange(
                           new Genre { Name = "Roman" },
                           new Genre { Name = "Nuvela" },
                           new Genre { Name = "Poezie" }
                );

                context.Customer.AddRange(
                    new Customer { Name = "Popescu Marcela", Adress = "Str. Plopilor, nr. 24", BirthDate = DateTime.Parse("1979-09-01") },
                    new Customer { Name = "Mihailescu Cornel", Adress = "Str. Bucuresti, nr. 45, ap. 2", BirthDate = DateTime.Parse("1969-07-08") }
                    );

                context.SaveChanges();
            }
        }
    }
}
