//using Batch1_DET_2022.Models.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class NewBookTable
//    {
      
        
//            public static void Main()
//            {
//                AddNewBook();
//                Console.ReadLine();
//            }

//            private static void AddNewBook()
//            {
//                var ctx = new BookContext();
//                Book book = new BooK();
//                book.BookID = 1;
//                book.BookName = "EF core";
//                book.author = "Jack";
//                book.Price = 100;
//                try
//                {
//                object value = ctx.Books.Add(book);
//                    ctx.SaveChanges();
//                    Console.WriteLine("new book added");


//                }
//                catch(Exception ex)
//                {
//                    Console.WriteLine(ex.InnerException.Message);
//                }

//            }
        
//    }
//}
