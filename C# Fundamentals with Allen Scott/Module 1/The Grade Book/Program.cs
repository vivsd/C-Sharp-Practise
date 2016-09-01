using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Grade_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(59);
            book.AddGrade(79);
            book.AddGrade(96);

            GradeStatistics status = new GradeStatistics();
            status = book.CompuStatistics();
            Console.WriteLine("Highest grade " + status.HighestGrade);
            Console.WriteLine("Average grade " + status.AverageGrade);
            Console.WriteLine("Lowest grade " + status.LowestGrade);
        }
    }
}
