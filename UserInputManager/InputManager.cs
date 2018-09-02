using Datalayer.Factory;
using Datalayer.Interfaces;
using Entities;
using HighSchoolManagement;
using HighSchoolManagement.Factories;
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
            string welcomeText = "Welcome to Junior High School! \nHere is a list of our students: \n";
            
            foreach (var student in DataFactory.GetStudent().RetrieveObjects())
            {
                welcomeText += " - " + student.Name + " \n";
            }

            welcomeText += "Type student name in order to retrieve information about them: ";

            Console.Write(welcomeText);
        }

        public void StudentInformation(string userInput)
        {
            var studentManagement = ManagementFactory.StudentsManagement();
            Console.WriteLine(studentManagement.StudentInformation(userInput));
        }
    }
}
