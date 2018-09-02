using System;
using UserInputManager;

namespace HighSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputManager = new InputManager();
            
            do
            {
                var userInput = Console.ReadLine();
                inputManager.StudentInformation(userInput);
            } while (Console.ReadLine() != "exit");
            
        }
    }
}
