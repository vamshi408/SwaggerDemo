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
    public class LoginController : ControllerBase
    {

        private readonly IRepository<Users> usersRepository;
        public LoginController(IRepository<Users> usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        // GET: api/<LoginController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public string Get(int id,string password)
        {
            string loginstatus = string.Empty;
            var data = usersRepository.GetSingle(id);
            if(data!=null)
            {
                //Owner
                if (data.UserPassword == password && data.TypeId==15)
                {
                    loginstatus = "Owner Login Success!";
                }
                //Customer
                if (data.UserPassword == password && data.TypeId == 23)
                {
                    loginstatus = "Customer Login Success!";
                }
                else
                {
                    loginstatus = "Login Failur!";
                }
            }
            else
            {
                loginstatus = "Login Failur!";
            }
            return loginstatus;
        }

        // POST api/<LoginController>
        [HttpPost]
        public void Post([FromBody] string userid, string password)
        {
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
