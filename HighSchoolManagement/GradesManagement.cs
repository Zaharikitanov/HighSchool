using Datalayer.Interfaces;
using Entities;
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

        public double ClassAverageGrade(int subjectClassId)
        {
            return Math.Round(GetClassGrades(subjectClassId).Average(), 2);
        }

        public double ClassHighestGrade(int subjectClassId)
        {
            return GetClassGrades(subjectClassId).Max();
        }

        private List<int> GetClassGrades(int subjectClassId)
        {
            List<int> gradesList = new List<int>();

            foreach (var grade in _gradesData.RetrieveObjects())
            {
                if (grade.ClassId == subjectClassId)
                {
                    gradesList.Add(grade.StudentGrade);
                }
            }
            return gradesList;
        }
    }
}
