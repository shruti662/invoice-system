using System;
using invoice_system.database;
using Microsoft.EntityFrameworkCore;

namespace invoice_system.Database
{
    public class InvoiceSystemDbContext : DbContext
    {
        public int WorkOrderDetails;
        public int GenerateInvoice;

        //public object applicationFormRepository;
        //public object concern_person_detail;

        public InvoiceSystemDbContext(DbContextOptions<InvoiceSystemDbContext> options)
            : base(options)
        {
        }
            public DbSet<company_details> company_details { get; set; }
            public DbSet<company_address> company_address { get; set; }
            public DbSet<concern_person_detail> concern_person_details { get; set; }
            public DbSet<City> city { get; set; }
            public DbSet<State> state { get; set; }
            public DbSet<Country> country { get; set; }
            public DbSet<work_order_details> work_order_details { get; set; }
            public DbSet<description_details> description_details { get; set; }

    }
}