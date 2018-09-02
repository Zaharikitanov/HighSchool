using Datalayer.Factory;
using Datalayer.Interfaces;
using Entities;
using HighSchoolManagement;
using System;

namespace UserInputManager
{
    public class InputManager
    {
        public InputManager()
        {
            Welcome();
        }

        private void Welcome()
        {
            string welcomeMenu = "Welcome to Junior High School! \nHere is a list of our students: \n";
            
            foreach (var student in DataFactory.GetStudent().RetrieveObjects())
            {
                welcomeMenu += " - " + student.Name + " \n";
            }

            welcomeMenu += "Type student name in order to retrieve information about them:";

            Console.WriteLine(welcomeMenu);
        }

        public void StudentInformation(string userInput)
        {
            var studentManagement = new StudentsManagement();
            Console.WriteLine(studentManagement.StudentInformation(userInput));
        }
    }
}
