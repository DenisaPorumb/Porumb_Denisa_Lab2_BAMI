using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Porumb_Denisa_Lab2.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int? CusstomerID { get; set; }
        public int? BookID { get; set; }

        public Customer? Customer { get; set; }
        public Book?Book { get; set; }
    }
}
