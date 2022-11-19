using OperatorOverloading_Indexer_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading_Indexer_Reflection.Services.Interface
{
    public interface IPersonService
    {
        List<string> GetFullData(Predicate<Person> predicate);


        int GetFilteredDatasCount(Predicate<Person> predicate);
    }
}
