using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _16_project_todo.helper;
using _16_project_todo.service;
using _16_project_todo.service.impl;

namespace _16_project_todo.view
{
    public class UserDisplay
    {
        public void DisplayMenu(IUserService userService)
        {
            bool loop = true;
            while (loop)
            {
                System.Console.WriteLine("Welcome to User Menu");
                System.Console.WriteLine("1. Update User");
                System.Console.WriteLine("2. Display User");
                System.Console.WriteLine("x. Exit");
                System.Console.Write("Enter your choice: ");
                string? choice = System.Console.ReadLine();

                if (String.IsNullOrEmpty(choice))
                    continue;

                switch (choice.ToLower())
                {
                    case "1":
                        userService.UpdateUser();
                        break;
                    case "2":
                        userService.ShowUser();
                        break;
                    case "x":
                        System.Console.WriteLine("Exit from User Menu");
                        loop = false;
                        break;
                    default:
                        System.Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
