using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Grade_Book
{
    class GradeStatistics
    {
        public GradeStatistics()
        {
            AverageGrade = 0;
            LowestGrade = float.MaxValue;
            HighestGrade = 0;

        }
           public float AverageGrade;
           public float HighestGrade;
           public float LowestGrade ;
    }
}
