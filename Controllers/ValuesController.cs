using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerDemo.Entity;
using SwaggerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IRepository<Users> usersRepository;
        public ValuesController(IRepository<Users> usersRepository)
        {
            this.usersRepository = usersRepository;
        }


        [Route("GetAllUsers")]
        [HttpGet]
        public IEnumerable<Users> GetAllUsers()
        {
            var data = usersRepository.GetAll();
            return data.Select(s=> new Users()
            {
                //UserId=s.UserId,
                UserName=s.UserName,
                UserEmailId=s.UserEmailId
            }).ToList();
        }

        [Route("GetAllUsers1")]
        [HttpGet]
        public IEnumerable<Users> GetAllUsers1()
        {
            var data = usersRepository.GetAll();
            return data.Select(s => new Users()
            {
                UserId = s.UserId,
                UserName = s.UserName,
                UserEmailId = s.UserEmailId
            }).ToList();
        }
    }
}
