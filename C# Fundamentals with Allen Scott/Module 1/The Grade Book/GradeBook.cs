using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Grade_Book
{
    class GradeBook
    {
        List<float> grades = new List<float>();

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
    }
}
