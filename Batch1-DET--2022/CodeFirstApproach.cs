using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Batch1_DET__2022.Data;
using Batch1_DET__2022.Models;
using Microsoft.EntityFrameworkCore;

namespace Batch1_DET__2022
{
    internal class CodeFirstApproach
    {

        static void Main(string[] args)
        {
            //AddNewBook();
            //UpdateBook();
            //DeleteBook();
            //GetAllBookDetails();
            //AddnewcustomerAndOrder();
            //GetAllCustomersWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();
            Console.ReadLine();
        }

        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 6;
        //    book.BookName = "In Cold Blood";
        //    book.author = "William";
        //    book.price = 200;


        //try
        //    {
        //        ctx.Books.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New book added successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void DeleteBook()
        //{
        //    var ctx = new BookContext();
        //    var Books = ctx.Books.Where(bk => bk.BookID == 4).SingleOrDefault();

        //    try
        //    {
        //        ctx.Remove(Books);
        //        ctx.SaveChanges();
        //        Console.WriteLine("book deleted successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        //private static void UpdateBook()
        //{
        //    var ctx = new BookContext();
        //    var Books = ctx.Books.Where(bk => bk.BookID == 5).SingleOrDefault();

        //    try
        //    {
        //        Books.author = "Henry";
        //        ctx.Update(Books);
        //        ctx.SaveChanges();
        //        Console.WriteLine("book Updated successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        //private static void GetAllBookDetails()
        //{
        //    var ctx = new BookContext();
        //    var Books = ctx.Books;

        //    foreach (var bk in Books)
        //    {
        //        Console.WriteLine( bk.BookName + " " + bk.author + " "+ bk.price);
        //    }
        //}

        //private static void AddnewcustomerAndOrder()
        //{
        //    var ctx = new BookContext();

        //    Customer customer = new Customer();
        //    customer.ID = 1;
        //    customer.Name = "John";
        //    customer.Age = 35;

        //    Order ord = new Order();
        //    ord.Order_ID = 100;
        //    ord.Amount = 2000;
        //    ord.OrderDate = DateTime.Now;

        //    ord.cust = customer;
        //    try
        //    {
        //        ctx.Orders.Add(ord);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Customer and order is created");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        //private static void GetAllCustomersWithOrder_EagerLoading()
        //{
        //    //Eager loading means that the related data is loaded 
        //    //from the database as part of the initial query.
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers.Include("Orders");

        //        //var customers = ctx.Customers.Include(o => o.Orders);                   

        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");


        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
        //            }
        //            Console.WriteLine("-----");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        //private static void GetAllCustomersWithOrder_ExplicitLoading()
        //{
        //    //Explicit loading means that the related data is
        //    //explicitly loaded from the database at a later time.
        //    //Needs MARS to be set to TRUE in connection string
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers;

        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");

        //            ctx.Entry(customer).Collection(o => o.Orders).Load();

        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());

        //            }
        //            Console.WriteLine("-----");

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

            ctx.Dispose();

            UpdateCustomerName(customer);

        }
        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Harshi";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            //  ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }
    } 
}
