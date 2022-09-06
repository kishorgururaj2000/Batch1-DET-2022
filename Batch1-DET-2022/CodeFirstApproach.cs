using Batch1_DET_2022.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Batch1_DET_2022.Models;

namespace Batch1_DET_2022
{
    internal class CodeFirstApproach
    {
        public static void Main()
        {

            
            Disconnectedarchitecture();
           // GetAllCustomersWithOrder_ExplicitLoading();
            //GetAllCustomersWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_EagerLoading();
            //AddnewcustomerAndOrder();
            //GetEmpStoredProcedure();
            // UpdateBook();
            // DeleteBook();
            //  AddNewBook();
            Console.ReadLine();
        }

        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 3;
        //    book.BookName = "TSql";
        //    book.author = "Sheela";
        //    book.price = 400;
        //    try
        //    {
        //        ctx.Book.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("new book added");


        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }


        //public static void DeleteBook()
        //{
        //    var ctx = new BookContext();
        //    var employee = ctx.Book.Where(b => b.BookID == 1).SingleOrDefault();
        //    try
        //    {
        //        ctx.Remove(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("employee deleted");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }



        //    //public static void UpdateBook()
        //    //{
        //    //    var ctx = new BookContext();
        //    //    var Books = ctx.Book.Where(b => b.BookID == 1).SingleOrDefault();
        //    //    try
        //    //    {


        //    //        Books.BookName = "hggftyf Design";
        //    //        Books.author = "hbjhgu";
        //    //        Books.price = 350;

        //    //        ctx.Update(Books);
        //    //        ctx.SaveChanges();
        //    //        Console.WriteLine("employee details updated");
        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        Console.WriteLine(ex.InnerException.Message);
        //    //    }
        //    //}





        //    //private static void GetEmpStoredProcedure()
        //    //{
        //    //    var ctx = new BookContext();
        //    //    var employees = ctx.Books.FromSqlRaw($"GetAllBook").ToList();

        //    //    foreach (var e in employees)
        //    //    {
        //    //        Console.WriteLine(e.author);
        //    //    }
        //    //}

        //}





        //private static void AddNewCustomerAndorder()
        //{
        //    var ctx = new BookContext();

        //    Customer customer = new Customer();
        //    customer.ID = 1;
        //    customer.Name = "John";
        //    customer.Age = 35;

        //    Order ord = new Order();
        //    ord.Order_ID = 101;
        //    ord.Amount = 2000;
        //    ord.OrderDate = DateTime.Now;

        //    try
        //    {
        //        ctx.Orders.Add(ord);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Customer and Order is created");

        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}





        //private static void AddnewcustomerAndOrder()
        //{
        //    var ctx = new BookContext();

        //    Customer customer = new Customer();
        //    customer.ID = 1;
        //    customer.Name = "Nancy";
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
        //        Console.WriteLine("Customer and order created");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.ToString());
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
            customer.Name = "Mike";
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

