using Datalayer.Interfaces;
using Entities;
using HighSchoolManagement.Enums;
using HighSchoolManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HighSchoolManagement
{
    public class GradesManagement : IGradesManagement
    {
        IDataComponents<IGrade> _gradesData;

        public GradesManagement(IDataComponents<IGrade> gradesData)
        {
            _gradesData = gradesData;
        }

        public string PersonalToClassGradeComparer(int subjectClassId, int studentId, GradeType gradeType)
        {
            string output = "";

            switch (gradeType)
            {
                case GradeType.Highest:
                    output = "highest grade: " + GetClassGrades(subjectClassId, studentId).Max()
                           + " out of " + GetClassGrades(subjectClassId).Max();
                    break;
                case GradeType.Average:
                    output = "average grade: " + Math.Round(GetClassGrades(subjectClassId, studentId).Average(), 2)
                           + " out of " + Math.Round(GetClassGrades(subjectClassId).Average(), 2);
                    break;
                default:
                    output = "Not implemented GradeType.";
                    break;
            }
            return output;
        }

        private List<int> GetClassGrades(int subjectClassId, int studentId = 0)
        {
            List<int> gradesList = new List<int>();

            foreach (var grade in _gradesData.RetrieveObjects())
            {
                if (studentId == 0)
                {
                    if (grade.ClassId == subjectClassId)
                    {
                        gradesList.Add(grade.StudentGrade);
                    }
                } else {
                    if (grade.ClassId == subjectClassId && grade.StudentId == studentId)
                    {
                        gradesList.Add(grade.StudentGrade);
                    }
                }
            }
            return gradesList.Distinct().ToList();
        }
    }
}
