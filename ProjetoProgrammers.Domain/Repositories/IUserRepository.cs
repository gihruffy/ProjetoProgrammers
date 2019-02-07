using ProjetoProgrammers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace ProjetoProgrammers.Domain.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int id);

        List<User> GetUsers();

        void Save(User user);

        void Update(User user);

        void Delete(int id);


    }
}
