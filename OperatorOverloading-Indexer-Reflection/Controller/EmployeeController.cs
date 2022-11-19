using OperatorOverloading_Indexer_Reflection.Services;
using OperatorOverloading_Indexer_Reflection.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading_Indexer_Reflection.Controller
{
    public class EmployeeController
    {

        public static void GetEmployeesSalaryAverage()
        {
            IEmployeeService employeeService = new EmployeeService();
            Console.WriteLine(employeeService.GetAllByAverageSalary(m=>m.Age>20 && m.Age<40));
        }
    }
}
