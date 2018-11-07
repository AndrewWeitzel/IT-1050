namespace Lab___3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instructor Declaration
            Instructor t1 = new Instructor("John", null, "English");
            Instructor t2 = new Instructor("Mike", null, "Math");
            //Instructor t3 = new Instructor("First", "Last", "Social Studies");
            #endregion

            #region Student Declaration
            Student s1 = new Student("Jane", t1, 0);
            Student s2 = new Student("Joe", t1, 0);
            Student s3 = new Student("Melissa", t2, 0);
            Student s4 = new Student("Matt", t2, 0);
            #endregion

            #region Setting Grades
            t1.SetStudentGrade(s1, 95);
            t1.SetStudentGrade(s2, 85);
            t2.SetStudentGrade(s3, 90);
            t2.SetStudentGrade(s4, 92);
            #endregion

            System.Console.WriteLine(s1.PrintSDetails());
            System.Console.WriteLine(s2.PrintSDetails());
            System.Console.WriteLine(s3.PrintSDetails());
            System.Console.WriteLine(s4.PrintSDetails());
            System.Console.ReadLine();
            System.Console.ReadKey();

        }
    }
}