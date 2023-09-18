using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class FinalExam : Exam
    {
        public override void ShowExam() // Show Final Exam to User 
        {
            Console.Clear();
            Console.WriteLine("------------------------ Final Exam Details ------------------------\n");
            Console.Write($"1. Time of Exam: {Time} minutes\t\t");
            Console.WriteLine($"2. Number of Questions: {NumberOfQuestions}\n\n");  
        }

        public override void ShowCorrectAnswers() // Show Questions , Answers and Grade
        {
            int i = 1;
            Console.WriteLine("\n ------------------------ Final Exam - Correct Answers And Grade: ------------------------ \n");
            foreach (var question in Questions)
            {
                Console.Write($"Question {i++}. {question.Body}.\t  ");
                question.CorrectTheExam();
                Console.WriteLine();
            }
            GradeExam();
        }

        public void GradeExam()
        {
            Console.Write ("\nGrading Final Exam = ");
            double? Sum = 0;
            foreach (var question in Questions)
            {
                Sum = Sum + question.Mark;
            }
            double Result = Answer.AnswerCount;
            Console.WriteLine($"{Result} / {Sum}");
        }
    }
}
