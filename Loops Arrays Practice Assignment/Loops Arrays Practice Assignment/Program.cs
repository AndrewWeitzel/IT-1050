namespace Loops_Arrays_Practice_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create and instanciate 3 people
            Person trump = new Person("Donald", "Trump");
            Person obama = new Person("Barack", "Obama");
            Person bush = new Person("George", "Bush");

            
            //Put each type-person inside the array
            Person[] people = new Person[3];
            
            //Could be written with less code thisaway
            //people[0] = new Person("Donald", "Trump");
            
            people[0] = trump;
            people[1] = obama;
            people[2] = bush;

            for (int i = 0;  i++; )
            {
                people[i] = Person.print();
            }

            foreach(Person person in people)
            {
                person.Print();
            }
        }
    }
   
}
