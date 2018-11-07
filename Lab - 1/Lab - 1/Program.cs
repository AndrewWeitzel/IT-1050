namespace Lab___1
{
    class Program
    {
        static void Main(string[] args)
        {
            //First name input
            System.Console.Write("What is your first name? ");
            string firstName;
            firstName = (System.Console.ReadLine());

            //Middle name input
            System.Console.Write("What is your middle name? ");
            string middleName;
            middleName = (System.Console.ReadLine());

            //Middle initial calculation
            string middleInitial;
            middleInitial = middleName.Substring(0, 1);

            //Last name input
            System.Console.Write("What is your last name? ");
            string lastName;
            lastName = (System.Console.ReadLine());

            string GetFullName()
            {
                string fullName;
                fullName = " ";
                fullName += firstName;
                fullName += " ";
                fullName += middleInitial;
                fullName += " ";
                fullName += lastName;
                return fullName;

            }

            //Height input & calculations
            System.Console.Write("How many feet tall are you? ");
            int heightFeet;
            heightFeet = int.Parse(System.Console.ReadLine());
            //if (heightFeet <= 0 || heightFeet <= 9) System.Console.WriteLine("Invaild entry please try start over...");

            System.Console.Write("and how many inches? ");
            double heightInches;
            heightInches = double.Parse(System.Console.ReadLine());
            //if (heightInches <= 0 || heightInches <= 12) System.Console.WriteLine("Invaild entry. Please start over... and remember there are 12 inches in a foot.");

            //Total to inches
            double totalHeightInches;
            totalHeightInches = (heightFeet * 12) + heightInches;
            //Total to centimeters
            double totalHeightCM;
            totalHeightCM = totalHeightInches * 2.54;

            //Age
            System.Console.WriteLine("How old are you? ");
            int personAge;
            personAge = int.Parse(System.Console.ReadLine());

            //Citizen Question
            System.Console.WriteLine("Are you a Citizen of the United States of America? (yes/no)");
            string isCitizenText;
            isCitizenText = (System.Console.ReadLine().ToLower());

            //Citizen string input to bool
            bool isCitizen = false;
            if (isCitizenText == "yes") isCitizen = true;

            //Voting age?
            bool canVote = false;
            if (personAge >= 18) canVote = true;


            //Original Attempt
            bool ableToVote = false;
            if (canVote == true && isCitizen == true) ableToVote = true;
            string voterStatement = " not ";
            if (ableToVote == true) voterStatement = " ";


            //Closing statements
            System.Console.Clear();
            System.Console.Beep();

            System.Console.WriteLine("Your full name is: ");
            System.Console.WriteLine(GetFullName());
            System.Console.WriteLine("Your height is " + totalHeightCM + " in centimeters.");
            System.Console.WriteLine("You are" + voterStatement + "able to vote.");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();

        }
    }
}
