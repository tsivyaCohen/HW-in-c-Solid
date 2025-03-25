using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UserRepository
    {
        private readonly DataContext _context;


        public UserRepository()
        {
            _context = new DataContext();
        }
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.First(u => u.Id == id);

        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }


        public User AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }


        public User UpdateUser(int id, User user)
        {
            User modifiedUser = _context.Users.First(u => u.Id == id);
            modifiedUser.Id = user.Id;
            modifiedUser.Name = user.Name;
            modifiedUser.Email = user.Email;
            modifiedUser.Age = user.Age;
            _context.SaveChanges();
            return modifiedUser;
        }
        public User DeleteUser(int id)
        {
            User user = _context.Users.First(u => u.Id == id);
            _context.Users.Remove(user);
            _context.SaveChanges();

            return user;
        }
    }
}
