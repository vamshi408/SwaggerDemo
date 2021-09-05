using SwaggerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SwaggerDemo.Entity
{
    public class UserRepository : IRepository<Users>
    {
        private readonly EntityDBContext _bVK_DB_Context;
        public UserRepository(EntityDBContext bVK_DB_Context)
        {
            _bVK_DB_Context = bVK_DB_Context;
        }


        //Implemented interface
        public IQueryable<Users> GetAll()
        {
            return _bVK_DB_Context.users;
        }

        //To Do need to implement other interfaces
        public void Add(Users entity)
        {
             _bVK_DB_Context.Add(entity);
            _bVK_DB_Context.SaveChanges();
        }

        public void Delete(Users entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Users entity)
        {
            _bVK_DB_Context.Update(entity);
            _bVK_DB_Context.SaveChanges();
        }

        public IQueryable<Users> FindBy(Expression<Func<Users, bool>> predicate)
        {
            throw new NotImplementedException();
        }
      

        public Users GetSingle(int id)
        {
           return _bVK_DB_Context.users.Where(u => u.UserId == id).FirstOrDefault();
            
        }

        public void SaveChanges()
        {
            _bVK_DB_Context.SaveChanges();
        }
    }
}
