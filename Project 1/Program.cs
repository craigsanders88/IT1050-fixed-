using System;

namespace The_Reqs_To_Vote.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Stranger! May I collect some information from you? I have candy...and a Van");

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;

            int age;
            int heightInFeet;
            int addInches; 
            
            double totalInches;
            double heightInches;
            double totalHeightInCM;
            
            bool isCitizen;                                   
            bool canVote;
                        
            System.Console.WriteLine("Who are you? State your first name please. ");
            firstName = System.Console.ReadLine();

            System.Console.WriteLine("How about a last name? ");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine("What's your middle initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.WriteLine("so....your full name is? ");
            fullName = System.Console.ReadLine();
             
            System.Console.WriteLine(fullName + " " + "...nice.");

            System.Console.WriteLine("WHATS YOUR SOCIAL SECURITY NUMBER!?!?!?...just kidding...trick question");

            System.Console.WriteLine("If im using your strange American metric system, how many feet tall are you? ");
            heightInFeet = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many additional inches are you? Please use a decimal for fractured measurements!! ");
            heightInches = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many inches is that in total? Remember, twelve inches equals a foot. ");
            totalInches= double.Parse(System.Console.ReadLine());
            
            System.Console.WriteLine("Thanks bro....getting information from you is pretty difficult. May I ask how old are you? ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Thanks!!! BTW I'm ordering your MAGA shirt. You told me your height earlier, so i'll convert it to centimeters. Should translate well since the shirts come from China. ");
            totalHeightInCM = (totalInches * 2.54);
            System.Console.WriteLine("You are " + totalInches * 2.54 + " cm "); 

            System.Console.WriteLine("Thanks!! We even scored expedited shipping...from Russia...wait a minute. " +
            "Oh before you leave, one quick question. Your a US citizen? True or False. ");
            isCitizen = bool.Parse(System.Console.ReadLine());

            canVote = (age < 18);

            System.Console.WriteLine(fullName +" " + " is a " + age +" "+  "year old citizen. " + firstName + " " + "has the right to vote. OH! He probably wears a large because he's " + totalHeightInCM + " cm in height. " ); 
                       
                       
        }


      
    }
}
