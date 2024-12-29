using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _16_project_todo.entity;
using _16_project_todo.helper;
using _16_project_todo.service;

namespace _16_project_todo.service.impl
{
    public class UserServiceImpl : IUserService
    {
        private User users = null!;

        public User GetUser()
        {
            if (users == null)
            {
                throw new InvalidOperationException("User has not been created yet.");
            }
            return users;
        }

        public void CreateUser()
        {
            string username = "";
            string password = "";
            while (true)
            {
                username = InputHelper.GetInput("Enter your username");
                if (username.Length > 1)
                {
                    break;
                }
                System.Console.WriteLine("Username cannot be empty");
            }

            while (true)
            {
                password = InputHelper.GetInput("Enter your password");
                if (password.Length >= 6)
                {
                    break;
                }
                System.Console.WriteLine("Password must be at least 6 characters");
            }

            int id = 1;
            users = new User(id, username, password);

            System.Console.WriteLine("======== New User Created =========");
            System.Console.WriteLine($"User ID: {users.Id}");
            System.Console.WriteLine($"Username: {users.Username}");
            System.Console.WriteLine("======== ========= =========");
        }

        public void ShowUser()
        {
            if (users == null)
            {
                System.Console.WriteLine("No user found. Please create a user first.");
                return;
            }
            System.Console.WriteLine("======== User Data =========");
            System.Console.WriteLine($"User ID: {users.Id}");
            System.Console.WriteLine($"Username: {users.Username}");
            System.Console.WriteLine($"Username: {users.Password}");
            System.Console.WriteLine("======== ========= =========");
        }

        public void UpdateUser()
        {
            if (users == null)
            {
                System.Console.WriteLine("No user found. Please create a user first.");
                return;
            }
            string username = InputHelper.GetInput($"Enter your new username ({users.Username})");
            string password = "";

            if (username.Length == 0)
            {
                username = users.Username;
            }

            while (true)
            {
                password = InputHelper.GetInput($"Enter your new password ({users.Password})");
                if (password.Length == 0)
                {
                    password = users.Password;
                    break;
                }

                users.Password = password;
                if (password.Length >= 6)
                {
                    break;
                }
                System.Console.WriteLine("Username must be at least 6 characters");
            }

            users.Username = username;

            System.Console.WriteLine("======== User Updated =========");
            System.Console.WriteLine($"User  ID: {users.Id}");
            System.Console.WriteLine($"Username: {users.Username}");
            System.Console.WriteLine("======== ========= =========");
        }
    }
}
