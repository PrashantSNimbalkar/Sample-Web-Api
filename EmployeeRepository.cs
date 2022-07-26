using SampleWebApi.Entities;
using SampleWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApi.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        RepositoriesContext _context;
        public EmployeeRepository(RepositoriesContext context)
        {
            _context = context;
        }
        public int AddEmployee(Employee emp)
        {
            _context.Employees.Add(emp);
            int res= _context.SaveChanges();
            return res;
        }

        public int DeleteEmployee(int id)
        {
            var emp = _context.Employees.Where(x => x.Id == id).SingleOrDefault();
            if (emp != null)
            {
                _context.Employees.Remove(emp);
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = _context.Employees.Where(x => x.Id == id).SingleOrDefault();
            return emp;
        }

        public int ModifyEmployee(Employee emp)
        {
            var em = _context.Employees.Where(x => x.Id == emp.Id).SingleOrDefault();
            if (em != null)
            {
                em.Name = emp.Name;
                em.Salary = emp.Salary;
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
