using LabTasks_15;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Task1
        Exam exam1 = new("Riyaziyyat", 25);
        Exam exam2 = new("Az-dili", 34);
        Exam exam3 = new("Kimya", 17);
        Exam exam4 = new("Fizika", 28);
        Exam exam5 = new("Biologiya", 15);

        Exam[] exams = {exam1,exam2,exam3,exam4,exam5};

        Student student1 = new("Selver", "Ceferov", "Riyaziyyat", 34);
        Student student2 = new("Selver", "Ceferov", "Riyaziyyat", 34);
        Student student3 = new("Selver", "Ceferov", "Riyaziyyat", 34);

        student1.CheckExam(exams);
        student2.CheckExam(exams);
        student3.CheckExam(exams);




        #endregion


    }
}