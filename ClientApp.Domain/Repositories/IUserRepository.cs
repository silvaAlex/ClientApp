using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ClientApp.Domain.Entities;

namespace ClientApp.Domain.Repositories
{
    public interface IUserRepository
    {
        User Get(Guid id);
        IEnumerable<User> GetAll(Expression<Func<User, object>> where);
        void Create(User user);
        void Update(User user);
        bool CPFExists(string cpf);
    }
}