using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _16_project_todo.entity;

namespace _16_project_todo.service
{
    public interface IUserService
    {
        User GetUser();
        void ShowUser();
        void CreateUser();
        void UpdateUser();
    }
}
