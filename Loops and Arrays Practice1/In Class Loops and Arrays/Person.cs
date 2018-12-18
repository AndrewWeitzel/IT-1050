namespace In_Class_Loops_and_Arrays
{
    class Person
    {
        public string firstName = "a";
        public string lastName = "z";

        public Person(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
 
        public void Print()
        {
            string fullName = firstName + " " + lastName;
            System.Console.WriteLine(fullName);
        }
    }
}
