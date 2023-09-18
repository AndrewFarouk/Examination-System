using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question>? Questions { get; set; }

        public abstract void ShowExam();
        public abstract void ShowCorrectAnswers();

        public void TimeAndNumberOfQuestions()
        {
            Console.Write($"Please Enter The Time Of Exam in Minutes: ");
            Time = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Please Enter The Number of Questions You Wanted To Created: ");
            NumberOfQuestions = Convert.ToInt32(Console.ReadLine());

            Questions = new List<Question>();
        }
    }
}
