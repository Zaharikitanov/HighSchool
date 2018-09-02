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
            string clasSubjectName = "";
            int studentId, subjectId;

            if (DataFactory.GetStudent().RetrieveObjects().Exists(x => x.Name == studentName))
            {
                studentId = ManagementFactory.StudentDetailsService().GetStudentId(studentName);
                var studentRecords = DataFactory.GetGrades().RetrieveObjects().Where(x => x.StudentId == studentId);

                studentInfo += studentName + " is attending the following classes: \n";

                foreach (var gradeId in studentRecords)
                {
                    ClassSubjectIdList.Add(gradeId.ClassId);
                }
                ClassSubjectIdList = ClassSubjectIdList.Distinct().ToList();

                foreach (var classSubjectId in ClassSubjectIdList)
                {
                    clasSubjectName = classSubjectsService.GetClassSubjectName(classSubjectId);
                    subjectId = classSubjectsService.GetClassSubjectById(clasSubjectName);

                    studentInfo += clasSubjectName 
                        + " with average grade of: " + gradesManagement.ClassAverageGrade(subjectId) 
                        + " and highest grade of: " + gradesManagement.ClassHighestGrade(subjectId) + "\n";
                }
            } else
            {
                studentInfo = "Enter valid student name, please.";
            }

            return studentInfo;
        }
    }
}
