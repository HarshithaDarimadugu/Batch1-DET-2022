using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Batch1_DET__2022.Models;
using Microsoft.EntityFrameworkCore;

namespace Batch1_DET__2022.Data
{
    public class BookContext : DbContext
    {
        public BookContext(){}

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }
     
        //public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=BG4WS1430\\SQLEXPRESS;Database=Training;Trusted_Connection=True;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Property configuration 

            //fluent API

            //modelBuilder.Entity<Book>()
            //    .Property(b => b.price)
            //    .IsRequired()//[Required]
            //    .HasColumnName("BKprice") //[Column ("bkprice)]
            //    .HasDefaultValue(200);
        }
            
    }
}

    
