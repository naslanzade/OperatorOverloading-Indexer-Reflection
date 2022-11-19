using OperatorOverloading_Indexer_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading_Indexer_Reflection.Services.Interface
{
    public  interface IBookService
    {
        int GetCount(Predicate<Book> predicate);
    }
}
