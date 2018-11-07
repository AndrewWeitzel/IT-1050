namespace Lab___3
{
    class Instructor
    {
        #region Instructor Variables
        private string teacherFirstName = "Kenny";
        private string teacherLastName = "Powers";
        private string courseName = "Gym";
        //private int studentGrade = 0;
        //public Student student;

        #endregion

        #region Instructor Constructor

        public Instructor(string first, string last, string course)
        {
            this.teacherFirstName = first;
            this.teacherLastName = last;
            this.courseName = course;

        }

        #endregion

        #region Class Methods
        public void SetStudentGrade(Student student, int grade)
        {

            student.StudentGrade(grade);
        }


        public void TeacherCreation(string first, string last, string course)
        {
            first = teacherFirstName;
            last = teacherLastName;
            course = courseName;
        }

        public string TeacherFullName()
        {
            string fullName;
            fullName = "";
            fullName += teacherFirstName;
            if (teacherLastName != null)
            {
                fullName += " ";
                fullName += teacherLastName;
            }
            return fullName;
        }


        public string PrintTDetails()
        {
            string nameAndCourse;
            nameAndCourse = "Teacher: ".PadLeft(5);
            nameAndCourse += this.TeacherFullName().PadRight(10);
            nameAndCourse += "Course Title: ";
            nameAndCourse += this.courseName.PadRight(10);
            return nameAndCourse;
        }
        #endregion
    }
}