using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _16_project_todo.service;
using _16_project_todo.service.impl;

namespace _16_project_todo.view
{
    public class AppDisplay
    {
        UserDisplay userDisplay = new UserDisplay();
        IUserService userService = new UserServiceImpl();

        public void AppMenu()
        {
            if (userService.GetUser != null)
            {
                userService.CreateUser();
            }

            bool isRunning = true;
            while (isRunning)
            {
                System.Console.WriteLine("=== WELCOME TO OUT APP ===");
                System.Console.WriteLine("1. User Menu");
                System.Console.WriteLine("2. Todo Menu");
                System.Console.WriteLine("x. Exit");
                string? choice = System.Console.ReadLine();

                if (String.IsNullOrEmpty(choice))
                    continue;

                switch (choice.ToLower())
                {
                    case "1":
                        userDisplay.DisplayMenu(userService);
                        break;
                    case "2":
                        System.Console.WriteLine("TODO MENU");
                        break;
                    case "x":
                        System.Console.WriteLine("Exit from application, Bye");
                        isRunning = false;
                        break;
                    default:
                        System.Console.WriteLine(" Please enter a valid choice.");
                        isRunning = false;
                        break;
                }
            }
        }
    }
}
