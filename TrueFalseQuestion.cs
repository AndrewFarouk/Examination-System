using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class TrueFalseQuestion : Question
    {
        public bool IsCorrectAnswer { get; set; }
        public bool IsSelectAnswer { get; set; }

        public override void CreateQuestion()  // Show Questions To Creator to Create Exam
        {
            Header = "True or False Question";
            Console.WriteLine(Header);
            Console.WriteLine("Please Enter The Body of Question:");
            Body = Console.ReadLine();
            Console.WriteLine("Please Enter The Marks Of Questions: ");
            Mark = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter The Right Answer of Question (1) for True && (2) for False:");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1 || answer == 2)
                IsCorrectAnswer = answer == 1;
            else 
                throw new Exception("Invalid Answer Choice.");


        }

        public override void ShowQuestionForSolve() // Show Questions To user and Can Solve it
        {
            Console.Write(Header + "\t\t");
            Console.WriteLine($"Marks ({Mark})\n");
            Console.WriteLine($"Question :: {Body}\n");
            Console.WriteLine("1. True\t\t2. False");
            Console.WriteLine("\n------------------------------------------------");
            Console.Write("Your Answer = ");

            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1 || answer == 2)
                IsSelectAnswer = answer == 1;
            else
                throw new Exception("Invalid Answer Choice.");
        }

        public override void CorrectTheExam()  // Show Answers to User
        {
            Answer answer = new Answer();  
            answer.CorrectTrueFalseQuestionAnswer(this);
        }

    }
}
