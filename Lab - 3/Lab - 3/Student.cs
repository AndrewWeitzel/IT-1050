namespace Lab___3
{
    class Student
    {
        #region Student Variables

        private string studentName;
        private int studentGrade = 0;
        private Instructor teacher;

        #endregion

        #region Student Constructor
        public Student(string name, Instructor teacher, int grade)
        {
            this.studentName = name;
            this.teacher = teacher;
            this.studentGrade = grade;
        }
        #endregion



        #region Student Class Methods
        public string PrintSDetails()
        {
            string studentDetails;
            studentDetails = "Student: ";
            studentDetails += this.studentName.PadRight(10);
            studentDetails += this.teacher.PrintTDetails().PadRight(10);
            studentDetails += "Grade: ".PadLeft(10);
            studentDetails += this.PercentageToLetterGrade();
            return studentDetails;
        }
        public void StudentGrade(int sGrade)
        {
            studentGrade = sGrade;
        }

        public string PercentageToLetterGrade()
        {
            string letterGrade;
            int letter;
            int plusMinusNull;
            string gradeRating;
            string finalGrade;

            letterGrade = studentGrade.ToString().Substring(0, 1);
            letter = int.Parse(letterGrade);

            if (letter <= 9)
            {
                letterGrade = "A";
            }
            if (letter == 8)
            {
                letterGrade = "B";
            }
            if (letter == 7)
            {
                letterGrade = "C";
            }
            if (letter == 6)
            {
                letterGrade = "D";
            }
            if (letter < 6)
            {
                letterGrade = "F";
            }

            gradeRating = studentGrade.ToString().Substring(1);
            plusMinusNull = int.Parse(gradeRating);

            if (plusMinusNull >= 7 && studentGrade >= 57)
            {
                gradeRating = "+";
            }
            if (plusMinusNull <= 3 && studentGrade > 53)
            {
                gradeRating = "-";
            }
            else { gradeRating = ""; }

            finalGrade = letterGrade + gradeRating;
            return finalGrade;
        }

        #endregion
    }
}