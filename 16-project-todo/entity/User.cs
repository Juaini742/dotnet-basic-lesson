using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _16_project_todo.entity
{
    public class User
    {
        public int? Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }

        public User() { }
    }
}
