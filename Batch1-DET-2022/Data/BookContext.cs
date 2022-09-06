using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022.Models.Data
{
    public class BookContext:DbContext
    {
        public BookContext()
        {

        }

        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }


        //public virtual DbSet<Book> Book { get; set; }
        public object Books { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=69R4RG2-SHEL\\SQLEXPRESS;Database=Training;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Book>()
            //    .Property(x => x.price)
            //    .IsRequired() //Required
            //    .HasColumnName("BKPrice")
            //    .HasDefaultValue(200);
        }
    }
}
