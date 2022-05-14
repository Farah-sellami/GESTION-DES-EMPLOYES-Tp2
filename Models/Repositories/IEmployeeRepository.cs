using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTp2.Models.Repositories
{
    public interface IEmployeeRepository
    {
        Employe GetEmployee(int Id);
        IEnumerable<Employe> GetAllEmployee();
        Employe Add(Employe employee);
        Employe Update(Employe employeeChanges);
        Employe Delete(int Id);

    }
}
