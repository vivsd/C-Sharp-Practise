using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Speech;
using System.Threading.Tasks;
using System.Speech.Synthesis;

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

            SpeechSynthesizer synth = new SpeechSynthesizer();

            GradeStatistics status = new GradeStatistics();
            status = book.CompuStatistics();
            Console.WriteLine("Highest grade " + status.HighestGrade);
            Console.WriteLine("Average grade " + status.AverageGrade);
            Console.WriteLine("Lowest grade " + status.LowestGrade);

            synth.Speak("Highest grade is " + status.HighestGrade.ToString());
            synth.Speak("Average grade is" + status.AverageGrade.ToString());
            synth.Speak("Lowest grade is " + status.LowestGrade.ToString());

            //synth.Speak(status.HighestGrade.ToString());
        }
    }
}
