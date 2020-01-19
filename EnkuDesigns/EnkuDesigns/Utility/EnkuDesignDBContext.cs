using EnkuDesigns.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnkuDesigns.Utility
{
    class EnkuDesignDBContext : DbContext
    {

        public DbSet<Dress> Dresses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TransactionReport> TransactionReports { get; set; }

    }
}
