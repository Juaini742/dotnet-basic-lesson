using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _16_project_todo.view;

namespace _16_project_todo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppDisplay appDisplay = new AppDisplay();

            appDisplay.AppMenu();
        }
    }
}
