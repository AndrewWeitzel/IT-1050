namespace Loops_Arrays_Practice_Assignment
{
    class Person
    {
        string firstName { set; get; }
        string lastName { set; get; }

        public Person (string first, string last)
        {
            firstName = first;
            lastName = last;

        }

        void Print()
        {
            System.Console.WriteLine(firstName + " " + lastName);
        }
                       
    }
}
