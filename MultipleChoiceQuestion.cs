using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class MultipleChoiceQuestion : Question
    {
        public List<string> Choices { get; set; }
        public int CorrectChoiceIndex { get; set; }
        public int UserChoiceIndex { get; set; }
        public string CorrectChoice => Choices[CorrectChoiceIndex];
        public string UserChoice => Choices[UserChoiceIndex];

        public MultipleChoiceQuestion() => Choices = new List<string>();

        public override void CreateQuestion() // Show Questions To Creator to Create Exam
        {
            Header = "Choose One Answer Question";
            Console.WriteLine(Header);
            Console.WriteLine("Please Enter The Body of Question:");
            Body = Console.ReadLine();
            Console.WriteLine("Please Enter The Marks Of Questions: ");
            Mark = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("----- Please Enter '0' When Finished -----:\n");
            string? choice;
            int i = 1;
            Console.Write($"Please Enter The Choice Number {i}. Choose: ");
            while ((choice = Console.ReadLine()) != "0")
            {
                Choices?.Add(choice);
                Console.Write($"Please Enter The Choice Number {++i}. Choose: ");
            }

            Console.WriteLine($"Please Enter The Index of the Correct Choice (1-{Choices?.Count}):");
            CorrectChoiceIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if (CorrectChoiceIndex < 0 || CorrectChoiceIndex >= Choices?.Count)
                throw new Exception("Invalid choice index.");
        }

        public override void ShowQuestionForSolve() // Show Questions To user and Can Solve it
        {
            Console.Write(Header + "\t\t");
            Console.WriteLine($"Marks ({Mark})\n");
            Console.WriteLine($"Question :: {Body}\n");

            Console.Write("Choices:   ");
            for (int i = 0; i < Choices?.Count; i++)
                Console.Write($"{i + 1}. {Choices[i]} \t ");
            
            Console.WriteLine("\n------------------------------------------------");
            Console.Write("Your Answer = ");
            UserChoiceIndex = Convert.ToInt32(Console.ReadLine()) -1;
            Console.WriteLine();
        }

        public override void CorrectTheExam() // Show Answers to User
        {
            Answer answer = new Answer();
            answer.CorrectMcqQuestionAnswer(this);
        }
    }
}


