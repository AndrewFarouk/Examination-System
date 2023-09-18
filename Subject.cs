using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam? exam { get; set; }

        public Subject(int _SubjectId, string _SubjectName)
        {
            SubjectId = _SubjectId;
            SubjectName = _SubjectName;
        }

        public void CreateExam()
        {
            Console.Write(" --------- Please Enter The Type Of Exam You Want To Create ---------\n (1) For Practical Exam && (2) For Final Exam: ");
            int TypeOfExam = Convert.ToInt32(Console.ReadLine());

            if (TypeOfExam == 1)
            {
                #region Create Practiacl Exam

                Exam practicalExam = new PracticalExam();
                practicalExam.TimeAndNumberOfQuestions();
                Console.Clear();

                for (int i = 1; i <= practicalExam?.NumberOfQuestions; i++)
                {
                    Question question = new MultipleChoiceQuestion();
                    question.CreateQuestion();
                    practicalExam?.Questions?.Add(question);
                    Console.WriteLine("\n======================================\n");
                }
                exam = practicalExam;
            }

            #endregion
            else if (TypeOfExam == 2)
            {
                #region Create Final Exam

                Exam finalExam = new FinalExam();
                finalExam.TimeAndNumberOfQuestions();
                Console.Clear();

                for (int i = 1; i <= finalExam?.NumberOfQuestions; i++)
                {
                    Console.WriteLine($"Please Choose The Type Of Question Number {i}:: (1) For True Or False && (2) For MCQ :");
                    int TypeOfQuestion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    Question question;

                    if (TypeOfQuestion == 1)
                        question = new TrueFalseQuestion();

                    else if (TypeOfQuestion == 2)
                        question = new MultipleChoiceQuestion();

                    else
                        throw new Exception("Invalid Question Type.");

                    question.CreateQuestion();
                    finalExam?.Questions?.Add(question);
                    Console.WriteLine("\n======================================\n");
                }
                exam = finalExam;
            }

            #endregion
            else
            {
                Console.WriteLine("Invalid Type");
                return;
            }


        }
            public void TakeExam()
            {
                if (exam == null)
                {
                    Console.WriteLine("\n================= No Exam Created =================.\n");
                    return;
                }

                exam.ShowExam();
                int i = 1;
                foreach (Question question in exam.Questions)
                {
                    Console.WriteLine($"\t\t\t======= {i++}. Question =======\n");
                    question.ShowQuestionForSolve();
                    Console.WriteLine("--------------------------------------------------------------------------------\n");
                }

                Console.Clear ();
                exam.ShowCorrectAnswers();
            }
    

    }
}
