using System.Diagnostics;

namespace Examination_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(10, "C#");
            subject.CreateExam();
            Console.Clear();

            Console.Write("Do you want to start the Exam (y | n): ");
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
                subject.TakeExam();
                Console.WriteLine($"The Elapsed Time = {SW.Elapsed}");
            }
        }
    }
}