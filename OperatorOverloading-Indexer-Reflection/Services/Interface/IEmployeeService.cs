

using OperatorOverloading_Indexer_Reflection.Models;

namespace OperatorOverloading_Indexer_Reflection.Services.Interface
{
    public interface IEmployeeService
    {

        double GetAllByAverageSalary(Predicate<Employee> predicate);
    }
}
