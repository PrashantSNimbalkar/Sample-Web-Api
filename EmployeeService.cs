using SampleWebApi.Model;
using SampleWebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        public int AddEmployee(Employee emp)
        {
            return _repo.AddEmployee(emp);
        }

        public int DeleteEmployee(int id)
        {
            return _repo.DeleteEmployee(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _repo.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return _repo.GetEmployeeById(id);
        }

        public int ModifyEmployee(Employee emp)
        {
            return _repo.ModifyEmployee(emp);
        }
    }
}
