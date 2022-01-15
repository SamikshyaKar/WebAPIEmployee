using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIEmployeeFull.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Employee> Employeeprop { get; set; }
        public DbSet<Department> departmentsprop { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
               new Department { DepartmentID = 1, DepartmentName = "IT" });

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentID = 2, DepartmentName = "HR" });

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentID = 3, DepartmentName = "PayRoll" });

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentID = 4, DepartmentName = "Staffing" });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmpID = 101,
                EmpFirstName = "Sara",
                EmpLastName = "Tondon",
                Email = "sara@gmail.com",
                EmpGender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "~/Wwwroot/Images/Flower1.jpg",
                EmpDateofBirth = new DateTime(2000, 9, 23)
            });


            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmpID = 102,
                EmpFirstName = "John",
                EmpLastName = "Srikant",
                Email = "John@gmail.com",
                EmpGender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "~/Wwwroot/Images/Flower2.jpg",
                EmpDateofBirth = new DateTime(2001, 9, 23)
            });
        }


    }
}
