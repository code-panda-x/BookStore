using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Order
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
}
