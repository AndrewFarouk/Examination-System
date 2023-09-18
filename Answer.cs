using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class Answer 
    {
        public static double AnswerCount = 0;
        
        public void CorrectTrueFalseQuestionAnswer(TrueFalseQuestion question)
        {
            string correctAnswer = question.IsCorrectAnswer ? "True" : "False";
            string userAnswer = question.IsSelectAnswer ? "True" : "False";

            if (userAnswer == correctAnswer)
            {
                Console.Write($"\tYour Answer: {correctAnswer}\t (Is Correct)");
                AnswerCount = AnswerCount + question.Mark;
            }
            else
            {
                Console.WriteLine($"\tYour Answer: {userAnswer}\t (Is Not Correct)");
                Console.WriteLine($"\t ====== Correct Answer: {correctAnswer} ======");
            }
        }

        public void CorrectMcqQuestionAnswer(MultipleChoiceQuestion question)
        {
            if (question.CorrectChoice == question.UserChoice)
            {
                Console.Write($"Your Answered : {question.UserChoice} \t (Is Correct)");
                AnswerCount = AnswerCount + question.Mark;
            }
            else
            {
                Console.WriteLine($"Your Answered : {question.UserChoice} \t (Is Not Correct)");
                Console.WriteLine($"\t ====== Correct Answer: {question.CorrectChoice} ======");
            }
        }

        public static double Grade() => AnswerCount;
    }
}
