using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTp2.Models.Repositories
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;
        public SqlEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Employe Add(Employe employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }
        public Employe Delete(int Id)
        {
            Employe employee = context.Employees.Find(Id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employe> GetAllEmployee()
        {
            return context.Employees;

        }

        public Employe GetEmployee(int Id)
        {
            return context.Employees.Find(Id);
        }

        public Employe Update(Employe employeeChanges)
        {
            var employee = context.Employees.Attach(employeeChanges);
            employee.State = EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;
        }
    }
}
