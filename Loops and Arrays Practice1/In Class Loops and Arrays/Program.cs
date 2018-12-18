namespace In_Class_Loops_and_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];
            people[0] = new Person("George", "Bush");
            people[1] = new Person("Barack", "Obama");
            people[2] = new Person("Donald", "Trump");

            
            foreach (Person person in people)
            {
                person.Print();
            }

            System.Console.ReadLine();
        }
    }
}
