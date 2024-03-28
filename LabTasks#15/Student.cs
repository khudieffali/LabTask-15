using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTasks_15
{
    internal class Student
    {
        public string Name;
        public string SurName;
        public string Faculty;
        public int UntilExamScore;
        public string Result;

        public Student(string name, string surName, string faculty, int untilExamScore)
        {
            Name = name;
            SurName = surName;
            Faculty = faculty;
            UntilExamScore = untilExamScore;
        }

        Exam exam = new();
        public void CheckExam(Exam[] exams)
        {
            foreach (var item in exams)
            {
                int points = 0;
                if (item.ExamScore > 17)
                {
                    points = item.ExamScore + UntilExamScore;
                    if (points > 50 && points < 60)
                    {
                        Result = "E";
                    }
                    else if (points > 60 && points < 70)
                    {
                        Result = "D";
                    }
                    else if (points > 70 && points < 80)
                    {
                        Result = "C";
                    }
                    else if (points > 80 && points < 90)
                    {
                        Result = "B";
                    }
                    else if (points > 90 && points < 100)
                    {
                        Result = "A";
                    }
                    else
                    {
                        Result = "F";
                        Console.WriteLine("Siz kesildiniz");
                    }
                }
                else
                {
                    Result = "F";
                    Console.WriteLine(item.Title+" bu fennen kesilmisiniz");
                }
                if(Result!="F")
                Console.WriteLine(item.Title+" fenninden neticeniz - "+Result);
            }



        }

        public void StudentInfo()
        {
            Console.WriteLine(Name + " " + SurName + " " + Faculty + " " + " " + UntilExamScore + " " + Result);
        }

    }
}
