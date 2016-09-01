using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Grade_Book
{
    class GradeBook
    {

        public GradeBook()
        {
                grades = new List<float>();
        }

        public GradeStatistics CompuStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach (float grade in grades)
            {
                sum += grade;
            }

            stats.AverageGrade = sum/grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        private List<float> grades;

    }
}
