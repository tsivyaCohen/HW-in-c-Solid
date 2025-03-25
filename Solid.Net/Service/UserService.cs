using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public class UserService
    {
        private UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);

        }

        public User GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }


        public User AddUser(User user)
        {
        return _userRepository.AddUser(user);
        }


        public User UpdateUser(int id, User user)
        {
        return _userRepository.UpdateUser(id, user);
        }
        public User DeleteUser(int id)
        {
           return (_userRepository.DeleteUser(id)); 


        }
        public void SendEmailToUser(int id)
        {
            User to = _userRepository.GetUserById(id);
            string userEmail = to.Email;

            //EmailPackage.SendEmail("api@gmail.com", userEmail, "Message" , "Content" );
        }


        private string EncodePassword(string password)
        {
            string hashedPassword = "";//כל תו ייוצג ע''י תו שנמצא 30 מקומות אחריו
            for (int i = 0; i < password.Length; i++)
            {
                hashedPassword += password[i] + 30;
            }
            return hashedPassword;
        }

    }
}