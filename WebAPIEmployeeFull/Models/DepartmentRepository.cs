using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIEmployeeFull.Models
{
    public class DepartmentRepository : IDepartmentrepository
    {
        private readonly AppDbContext appdbcontext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appdbcontext = appDbContext;
        }
        public  async Task<IEnumerable<Department>> GetallDepartments()
        {
            return await appdbcontext.departmentsprop.ToListAsync();
        }

        public  async Task<Department> GetDepartmentbyID(int DeptID)
        {
            return await appdbcontext.departmentsprop.FirstOrDefaultAsync(e => e.DepartmentID == DeptID);
        }
    }
}
