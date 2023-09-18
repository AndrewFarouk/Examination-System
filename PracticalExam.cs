using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class PracticalExam : Exam
    {
        public override void ShowExam() // Show Practical Exam to User 
        {
            Console.Clear();
            Console.WriteLine("------------------------ Practical Exam Details ------------------------\n");
            Console.Write($"1. Time of Exam: {Time} minutes\t\t");
            Console.WriteLine($"2. Number of Questions: {NumberOfQuestions}\n\n");
        }

        public override void ShowCorrectAnswers() // Show Questions and Answers to User
        {
            int i = 1;
            Console.WriteLine("\n ------------------------ Practical Exam - Correct Answers: ------------------------ \n");
            foreach (var question in Questions)
            {
                Console.Write($"Question {i++}. {question.Body}.\t  ");
                question.CorrectTheExam();
                Console.WriteLine();
            }
        }
    }
}
