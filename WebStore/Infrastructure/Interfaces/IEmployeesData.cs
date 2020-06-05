using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebStore.Models;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IEmployeesData
    {
        IEnumerable<Employee> Get();

        Employee GetById(long id);

        long Add(Employee employee);

        void Edit(Employee employee);

        EntityEntry<Employee> Delete(long id);

        void SaveChanges();
    }
}