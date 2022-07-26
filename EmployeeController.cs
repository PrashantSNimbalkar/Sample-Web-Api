using Microsoft.AspNetCore.Mvc;
using SampleWebApi.Model;
using SampleWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        [Route("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            return new ObjectResult(_service.GetAllEmployees());
        }

        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return new ObjectResult(_service.GetEmployeeById(id));
        }


        // POST api/<EmployeeController>
        [HttpPost]
        [Route("AddEmployee")]
        public int AddEmployee([FromBody] Employee emp)
        {
            return _service.AddEmployee(emp);
        }

        [HttpPost]
        [Route("ModifyEmployee")]
        public int ModifyEmployee([FromBody] Employee emp)
        {
            return _service.ModifyEmployee(emp);
        }
      

        // DELETE api/<EmployeeController>/5
        [HttpGet("{id}")]
        [Route("DeleteEmployee/{id}")]
        public int DeleteEmployee(int id)
        {
            return _service.DeleteEmployee(id);
        }
    }
}
