using OperatorOverloading_Indexer_Reflection.Services;
using OperatorOverloading_Indexer_Reflection.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading_Indexer_Reflection.Controller
{
    public class BookController
    {

        public static void GetCount()
        {
            IBookService bookService = new BookService();
            Console.WriteLine(bookService.GetCount(m=>m.Author=="Nizami"));
        }
    }
}
