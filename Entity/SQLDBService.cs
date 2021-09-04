using SwaggerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SwaggerDemo.Entity
{
    public class SQLDBService  : IRepository<Users>
    {
        private readonly EntityDBContext _bVK_DB_Context;
        public SQLDBService(EntityDBContext bVK_DB_Context)
        {
            _bVK_DB_Context = bVK_DB_Context;
        }

        #region User Repository
        //Implemented interface
        public IQueryable<Users> GetAll()
        {
            return _bVK_DB_Context.users;
        }

        //To Do need to implement other interfaces
        public void Add(Users entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Users entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Users entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Users> FindBy(Expression<Func<Users, bool>> predicate)
        {
            throw new NotImplementedException();
        }


        public Users GetSingle(Expression<Func<Users, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
