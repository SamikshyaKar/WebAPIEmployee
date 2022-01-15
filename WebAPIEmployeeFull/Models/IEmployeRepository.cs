using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIEmployeeFull.Models
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployeeByID(int EmpID);
        Task<IEnumerable<Employee>> GetAllEmployee();

        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee Employee);
        Task DeleteEmployee(int EmpID);

        Task<IEnumerable<Employee>> SearchEmployee(string name, Gender? gender);
        Task<Employee> GetEmployeebyEmail(string EmpEmail);




    }
}
