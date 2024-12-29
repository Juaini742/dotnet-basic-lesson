using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _16_project_todo.helper
{
    public class InputHelper
    {
        public static string GetInput(string message)
        {
            System.Console.Write($"{message}: ");
            string? input = Console.ReadLine();
            return input ?? throw new InvalidOperationException("Input cannot be null.");
        }
    }
}
