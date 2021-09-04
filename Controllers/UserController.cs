using Microsoft.AspNetCore.Mvc;
using SwaggerDemo.Entity;
using SwaggerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerDemo.Controllers
{
    public class UserController : Controller
    {
        private readonly IRepository<Users> usersRepository;
        public UserController(IRepository<Users> usersRepository)
        {
            this.usersRepository = usersRepository;
        }
        public IEnumerable<Users> GetAllUsers()
        {
            var data = usersRepository.GetAll().ToList();
            return data;
        }
    }
}
