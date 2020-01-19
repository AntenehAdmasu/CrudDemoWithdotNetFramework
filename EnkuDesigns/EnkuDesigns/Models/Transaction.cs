using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnkuDesigns.Models
{
    class Transaction
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public double Price { get; set; }
        public string Cashier { get; set; }
        public  String Date { get; set; }
        public string Type { get; set; }

    }
}
