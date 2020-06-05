using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;
// using WebStore.Data;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Infrastructure.Services
{
    public class EmployeesData : IEmployeesData
    {
        //private readonly List<Employee> _employees = TestData.Employees;
        private readonly AppDbContext _context;

        // public EmployeesData(AppDbContext context)
        public EmployeesData(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> Get() => _context.Employee;

        public Employee GetById(long id) => _context.Employee.FirstOrDefault(e => e.Id == id);

        public long Add(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(employee));

            if (_context.Employee.Contains(employee))
                return employee.Id;

            employee.Id = _context.Employee.Max(e => e.Id) + 1;
            _context.Employee.Add(employee);
            return employee.Id;
        }

        public void Edit(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(employee));

            if (_context.Employee.Contains(employee))
                return;

            var dbItem = GetById(employee.Id);

            dbItem.FirstName = employee.FirstName;
            dbItem.LastName = employee.LastName;
        }

        public EntityEntry<Employee> Delete(long id)
        {
            var dbItem = GetById(id);

            if (dbItem is null)
                return null;

            return _context.Employee.Remove(dbItem);
        }

        public void SaveChanges()
        {
        }
    }
}