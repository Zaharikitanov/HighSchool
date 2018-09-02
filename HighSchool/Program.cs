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
                inputManager.StudentInformation(Console.ReadLine());
            } while (Console.ReadLine() != "exit");
            
        }
    }
}
