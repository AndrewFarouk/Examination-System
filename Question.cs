using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public abstract class Question
    {
        public string? Header { get; set; }
        public string? Body  { get; set; }
        public double Mark { get; set; }

        public abstract void CreateQuestion();
        public abstract void ShowQuestionForSolve();
        public abstract void CorrectTheExam();
  
    }
}
