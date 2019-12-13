namespace The_Two_Couples
{
    class Adult
    {
        public string firstName;
        public string lastName;
        public int age;
        public Adult spouse;

        public static int Count;                             //Static Void, section 2, video 3, 7:40 mark, does not exist on instance objects --exist ONCE on the class.
        public static int SumOfAllAges;                     //*see above, tip: Typle in class type and then "." Brings up list of what can be used after class type. good for programs using averages
                                                            //*int numAdults = 0 was replaced by public static int count, Static Void, section 2, video 3, 3:30-11:00 mark 
        public string GetFullName()
        {
            return this.firstName + " " + lastName;
        }

        public static double AverageAge()                  // You use the double variable because you get the average by adding all ages and divided by count and most likely will have a decimal point.
        {
            return (double)Adult.SumOfAllAges / (double)Adult.Count;
        }

        public void AskUserForNameAndAge()               //GitHub, IT1050, Section 2, Example4_, Example5_,or  Orders.cs, Programs.cs, Questions.cs, assignment solved
        {
            System.Console.Write("First Name: ");
            this.firstName = System.Console.ReadLine();
            System.Console.Write("Last Name: ");
            this.lastName = System.Console.ReadLine();
            System.Console.Write("Age: ");
            this.age = int.Parse(System.Console.ReadLine());
            Adult.Count++;
            Adult.SumOfAllAges += this.age;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
            System.Console.WriteLine(this.age);
        }

        public void CreateSpouseIfMarried()
        {
            System.Console.WriteLine(" Are you married? y/n: ");

            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                this.spouse = new Adult();
                this.spouse.AskUserForNameAndAge();
                this.spouse.spouse = this;
            }
        }
    }
}
