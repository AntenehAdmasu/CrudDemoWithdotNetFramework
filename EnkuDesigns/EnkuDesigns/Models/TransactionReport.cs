using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnkuDesigns.Models
{
    public class TransactionReport
    {
        public int Id { get; set; }
        public String Date { get; set; }
        public double Sale { get; set; }
        public double Expense { get; set; }
        public double Net { get; set; }
    }
}
