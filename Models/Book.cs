using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Porumb_Denisa_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
       
        public decimal Price { get; set; }

        [Display(Name = "Genre")]
        public int? GenreID { get; set; }
        public Genre? Genre { get; set; }

        [Display(Name = "Author")]
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}
