namespace Lab___2
{
    class Person
    {
        #region Person Variables
        public Person Spouse;
        public int personAge;
        public string personFirstName = null;
        public string personLastName = null;
        public string hitched;
        #endregion

        #region Program Variables
        public bool ageValid = false;
        public static int ageIncidence;
        public static double SumOfAllAges;
        public static int personCount;
        public string pFirst;
        public string pLast;
        #endregion

        #region Person Methods
        public string MaritalStatus()
        {
            System.Console.WriteLine("Is " + this.personFirstName + " married?");
            this.hitched = System.Console.ReadLine().ToLower().Substring(0, 1);
            if (this.hitched == "y")
            {
                Spouse = new Person();

            }
            return this.hitched;

        }

        public void SpouseNameRundown(string pFirst, string pLast)
        {
            System.Console.WriteLine("What is the first name of " + pFirst + "'s Spouse?");
            personFirstName = System.Console.ReadLine();
            System.Console.WriteLine("Do the couple share the same last name of " + pLast + "?");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                personLastName = pLast;
            }
            else
            {
                System.Console.WriteLine("What is the spouse's last name?");
                personLastName = System.Console.ReadLine();
            }
        }

        public void NameInput()
        {
            System.Console.WriteLine("What is Person " + personCount + "'s first name?");
            this.personFirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is Person " + personCount + "'s last name?");
            this.personLastName = System.Console.ReadLine();

        }

        public int AgeInputAndCheck()
        {
            System.Console.WriteLine("What is " + this.personFirstName + "'s age?");
            this.personAge = 0;

            while (this.ageValid == false)
            {
                try
                {
                    this.personAge = int.Parse(System.Console.ReadLine());
                    this.ageValid = true;
                    SumOfAllAges += this.personAge;
                    ageIncidence++;
                    break;
                }
                catch (System.FormatException ageError)
                {
                    System.Console.WriteLine(ageError.Message);
                    System.Console.WriteLine("Please enter a valid number...");
                    this.ageValid = false;
                    continue;
                }

            }

            return this.personAge;
        }

        public string GetFullName()
        {
            string fullName;
            fullName = " ";
            fullName += personFirstName;
            fullName += " ";
            fullName += personLastName;
            return fullName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine("Name: " + "\t" + this.GetFullName() + "\t" + " Age: " + "\t" + this.personAge);
            System.Console.ReadLine();
            if (this.hitched == "y")
            {
                System.Console.WriteLine("Name: " + "\t" + this.Spouse.GetFullName() + "\t" + " Age: " + "\t" + this.Spouse.personAge);
                System.Console.ReadLine();
            }
        }
        #endregion
    }
}