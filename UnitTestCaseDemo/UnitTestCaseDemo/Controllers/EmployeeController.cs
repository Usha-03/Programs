﻿using Microsoft.AspNetCore.Mvc;
using UnitTestCaseDemo.Model;
using UnitTestCaseDemo.Services;

namespace UnitTestCaseDemo.Controllers
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
        [HttpGet]
        public ActionResult Get()
        {
            var emps = _service.GetAll();
            return Ok(emps);
            //return View();
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var emp = _service.GetById(id);
            if (emp == null)
                return NotFound();
            return Ok(emp);
        }
        [HttpPost]
        public ActionResult Post([FromBody] Employee emp)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newEmp = _service.Add(emp);
            return CreatedAtAction(nameof(Get), new { id = newEmp.Id }, newEmp);
            //return CreatedAtAction("Get", newEmp);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_service.Delete(id))
                return Ok("The employee is deleted.");
            else
                return NotFound("The Employee not Found");
        }
    }
}
