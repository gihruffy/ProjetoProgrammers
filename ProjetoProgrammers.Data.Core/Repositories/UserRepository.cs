using System;
using System.Collections.Generic;
using System.Text;
using ProjetoProgrammers.Data.Context;
using ProjetoProgrammers.Domain.Entities;
using ProjetoProgrammers.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ProjetoProgrammers.Data.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public User GetUser(int id)
        {
            User user = _context.Users.Find(id);
            return user;
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public void Save(User user)
        {
            _context.Users.Add(user);
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            User user = _context.Users.Find(id);
            _context.Entry(user).State = EntityState.Deleted;
        }

    }
}
