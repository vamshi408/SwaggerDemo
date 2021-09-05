using Microsoft.AspNetCore.Mvc;
using SwaggerDemo.Entity;
using SwaggerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwaggerDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {

        private readonly IRepository<Users> usersRepository;
        public RegisterController(IRepository<Users> usersRepository)
        {
            this.usersRepository = usersRepository;
        }



        // GET: api/<RegisterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RegisterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RegisterController>
        [HttpPost]
        public void Post([FromBody] Users users)
        {
            usersRepository.Add(users);
        }

        // PUT api/<RegisterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegisterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
