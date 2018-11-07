namespace Lab___2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Person#1
            Person p1 = new Person();
            Person.personCount++;
            p1.NameInput();
            p1.AgeInputAndCheck();
            p1.MaritalStatus();
            if (p1.hitched == "y")
            {
                p1.Spouse = new Person();
                p1.Spouse.SpouseNameRundown(p1.personFirstName, p1.personLastName);
                p1.Spouse.AgeInputAndCheck();

            }
            #endregion

            #region Person #2
            Person p2 = new Person();
            Person.personCount++;
            p2.NameInput();
            p2.AgeInputAndCheck();
            p2.MaritalStatus();
            if (p2.hitched == "y")
            {
                p2.Spouse = new Person();
                Person.personCount++;
                p2.Spouse.SpouseNameRundown(p2.personFirstName, p2.personLastName);
                p2.Spouse.AgeInputAndCheck();

            }
            #endregion

            #region Close Outs and Math
            p1.PrintNameAndAge();
            p2.PrintNameAndAge();
            System.Console.ReadLine();

            System.Console.WriteLine
                (
                "The average age is: " + "\t [" +
                (Person.SumOfAllAges / Person.ageIncidence) + "]");
            System.Console.ReadLine();
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
            #endregion

        }
    }
}