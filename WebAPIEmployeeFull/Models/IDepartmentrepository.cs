using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIEmployeeFull.Models
{
    public interface IDepartmentrepository
    {

        Task<IEnumerable<Department>> GetallDepartments();
        Task<Department> GetDepartmentbyID(int DeptID);


    }
}
