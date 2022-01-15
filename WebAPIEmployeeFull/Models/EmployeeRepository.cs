using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIEmployeeFull.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appdbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            this._appdbContext = appDbContext;
        }
        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int EmpID)
        {
            throw new NotImplementedException();
        }

        public  async Task<IEnumerable<Employee>> GetAllEmployee()
        {
            return await _appdbContext.Employeeprop.ToListAsync();
        }

        public Task<Employee> GetEmployeebyEmail(string EmpEmail)
        {
            throw new NotImplementedException();
        }

        public  async Task<Employee> GetEmployeeByID(int EmpID)
        {
            var result = await _appdbContext.Employeeprop.FirstOrDefaultAsync(e => e.EmpID == EmpID);
            return result;
        }

        public Task<IEnumerable<Employee>> SearchEmployee(string name, Gender? gender)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployee(Employee Employee)
        {
            throw new NotImplementedException();
        }
    }
}
