using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Lab9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // takes string input parses to an in which is an index value and prints the name of student at that value
            List<string> studentNames = new List<string>(); //0-15 values
                                                            //methods (Add method) to start building chain of links of a list
            studentNames.Add(""); //first link of chain
            studentNames.Add("Jesse"); //first link of chain
            studentNames.Add("Chris"); //second link of chain
            studentNames.Add("Zac"); // link of chain
            studentNames.Add("Schwartz");
            studentNames.Add("Ash");
            studentNames.Add("Terrell");
            studentNames.Add("Samantha");
            studentNames.Add("Demarko");
            studentNames.Add("Terri");
            studentNames.Add("Patrick");
            studentNames.Add("Drew");
            studentNames.Add("Kristen");
            studentNames.Add("BJ");
            studentNames.Add("Will");
            studentNames.Add("Dr. K");
            studentNames.Add("Jacob");

            List<string> stuHometown = new List<string>();
            stuHometown.Add("");
            stuHometown.Add("Royal Oak, MI");
            stuHometown.Add("Livonia, MI");
            stuHometown.Add("Wyandotte, MI");
            stuHometown.Add("West Bloomfield, MI");
            stuHometown.Add("Detroit, MI");
            stuHometown.Add("Detroit, MI");
            stuHometown.Add("Clawson, MI");
            stuHometown.Add("Novi, MI");
            stuHometown.Add("Southfield, MI");
            stuHometown.Add("Detroit, MI");
            stuHometown.Add("Detroit, MI");
            stuHometown.Add("Berkley, MI");
            stuHometown.Add("Detroit, MI");
            stuHometown.Add("Farmington Hills, MI");
            stuHometown.Add("Detroit, MI");
            stuHometown.Add("Gary, IN");

            List<string> favFood = new List<string>();
            favFood.Add("");
            favFood.Add("pizza");
            favFood.Add("tacos");
            favFood.Add("french fries");
            favFood.Add("cheeseburgers");
            favFood.Add("sushi");
            favFood.Add("salad");
            favFood.Add("chicken shawarma");
            favFood.Add("chicken nuggets");
            favFood.Add("pizza");
            favFood.Add("pulled pork sandwich");
            favFood.Add("tacos");
            favFood.Add("hamburgers");
            favFood.Add("meatloaf");
            favFood.Add("sushi");
            favFood.Add("soup");
            favFood.Add("garlic bread");


            List<string> studentHobbies = new List<string>();
            studentHobbies.Add("");
            studentHobbies.Add("Running");
            studentHobbies.Add("Reading");
            studentHobbies.Add("Wearing cool shirts");
            studentHobbies.Add("Playing video games");
            studentHobbies.Add("Memes");
            studentHobbies.Add("Growing his business");
            studentHobbies.Add("handstands");
            studentHobbies.Add("stepping");
            studentHobbies.Add("shopping");
            studentHobbies.Add("juggling");
            studentHobbies.Add("stepping");
            studentHobbies.Add("cosplay");
            studentHobbies.Add("going to the gym");
            studentHobbies.Add("playing guitar");
            studentHobbies.Add("playing basketball");
            studentHobbies.Add("playing a show with his band");
            
            int stuNumber;
            // string regex = @"^\d[1 - 20]$";
            string homeFoodHobby = "";
            string userResponse;

            do
            {
                try
                {
                    //shows student option numbers
                    Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number from 0-20)");
                    stuNumber = int.Parse(Console.ReadLine()); // takes in number converts
                }
                catch (Exception ex)
                {
                    if (ex is FormatException || ex is OverflowException)
                    {
                        //WebId = Guid.Empty;
                        Console.WriteLine("Sorry! Only numbers allowed. Please enter a number 0-20.");

                    }

                    throw;
                }


                bool userValidation = true; // while the condition is true, loop
                while (userValidation) // validates int if it's in range
                {
                    if (stuNumber <= 0 || stuNumber > studentNames.Count) // input int range is over the # of student data true so loop 
                    {
                        Console.WriteLine("Sorry! That student doesn't exist. Please try again with a number from (1-20)");
                        // Console.WriteLine(Regex.IsMatch(stuNumber regex, RegexOptions.IgnoreCase);
                        stuNumber = int.Parse(Console.ReadLine());
                    }
                    else  // if in range, print this student info
                    {
                        Console.WriteLine("Student " + stuNumber + " is " + studentNames[stuNumber] + ". What would you like to know about " + studentNames[stuNumber] + "? (enter \"hometown\" or \"favorite food\" or \"hobbies\"");
                        homeFoodHobby = Console.ReadLine(); //using lists
                        userValidation = false; // set to false to leave loop
                    }

                }
                // reset bool to continue to next loop 
                userValidation = true;
                while (userValidation)
                {
                    if (homeFoodHobby == "hometown")
                    {
                        Console.WriteLine(studentNames[stuNumber] + " is from " + stuHometown[stuNumber] + ".");
                        userValidation = false;
                        //need to write for if yes or no
                    }

                    else if (homeFoodHobby == "favorite food")
                    {
                        Console.WriteLine(studentNames[stuNumber] + "'s " + "favorite food is " + favFood[stuNumber] + ". ");
                        userValidation = false;

                    }

                    else if (homeFoodHobby == "hobbies")
                    {
                        Console.WriteLine(studentNames[stuNumber] + "'s " + "hobbie is " + studentHobbies[stuNumber] + ". ");
                        userValidation = false;
                    }

                    else
                    {
                        Console.WriteLine("Sorry! That data does not exist. Please try again. Enter either \"hometown\", \"favorite food\" or \"hobbies\":");
                        userResponse = Console.ReadLine();
                    }
                }
                Console.WriteLine("Would you like more information on " + studentNames[stuNumber] + "or another student? To learn more enter \"y\" to exit \"n\"");
                userResponse = Console.ReadLine();
                //run code as long as the user says y; break when n
            }
            while (userResponse.ToLower() == "y");
        }
    }
}
// method to print out a list
/*public static void PrintList(List<string> list)
{
    foreach (string items in list)
    {
        Console.WriteLine(items);
    }
}*/
