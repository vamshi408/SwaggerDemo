using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerDemo.Models
{
   public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserMobileNumber { get; set; }
        public string UserEmailId { get; set; }
        public string UserPassword { get; set; }
        public int TypeId { get; set; }

    }
}
