using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTasks_15
{
    internal class Exam
    {
        public string Title { get; set; }
        public int ExamScore { get; set; }
        public Exam(string title, int examScore)
        {
            Title = title;
            ExamScore = examScore;
        }

        public Exam()
        {
        }
    }
}
