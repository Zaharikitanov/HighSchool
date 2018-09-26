using Datalayer.Factory;
using HighSchoolManagement.Factories;
using System.Collections.Generic;
using System.Linq;

namespace HighSchoolManagement
{
    public class StudentsManagement : IStudentsManagement
    {
        public StudentsManagement()
        {
        }

        public string StudentInformation(string studentName)
        {
            var classSubjectsService = ManagementFactory.ClassSubjectDetailsService();
            var gradesManagement = ManagementFactory.GradesManagement();

            List<int> ClassSubjectIdList = new List<int>();
            string studentInfo = "";

            if (DataFactory.GetStudent().RetrieveObjects().Exists(x => x.Name == studentName))
            {
                int studentId = ManagementFactory.StudentDetailsService().GetStudentId(studentName);
                var studentRecords = DataFactory.GetGrades().RetrieveObjects().Where(x => x.StudentId == studentId);

                studentInfo += "\n" + studentName + " is attending the following classes: \n";

                foreach (var gradeId in studentRecords)
                {
                    ClassSubjectIdList.Add(gradeId.ClassId);
                }

                foreach (var classSubjectId in ClassSubjectIdList.Distinct().ToList())
                {
                    studentInfo += classSubjectsService.GetClassSubjectName(classSubjectId)
                        + " with " + gradesManagement.PersonalToClassGradeComparer(classSubjectId, studentId, Enums.GradeType.Highest) 
                        + " and " + gradesManagement.PersonalToClassGradeComparer(classSubjectId, studentId, Enums.GradeType.Average)
                        + "\n";
                }
            }
            else
            {
                studentInfo = "Enter valid student name, please.";
            }
            return studentInfo;
        }
    }
}
