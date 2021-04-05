using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Pay
    {
        public int ID { get; set; }
        public int Credit_Card_Number { get; set; }

        [DataType(DataType.Date)]
        public DateTime Expire_Date { get; set; }
    }
}
