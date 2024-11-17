namespace GDAPS_DebuggingStarter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable block
            string userNumber1AsString = "";
            string userNumber2AsString = "";
            string userAngleAsString = "";
            string userName = "";
            string newName = "";

            double userNumber1AsInt = 0;
            double userNumber2AsInt = 0;

            int userAngleAsInt = 0;
            double userAngleAsDouble = 0;

            double percentage;
            double percentageVal;


            // Ask the user for:
            //   1. number between 1 and 100
            //   2. number between 1 and 9 over 10
            // This program calculates X percentage of the first given number
            //   where the second number is a percentage from 0 to 100%.
            Console.WriteLine("Hi there! This is the percent calculator.");
            Console.WriteLine("Give me a number and I'll calculate it to your given percentage.");
            Console.WriteLine();
            Console.Write("First, enter a number between 1 and 100: ");
            userNumber1AsString = Console.ReadLine();
            userNumber1AsInt = double.Parse(userNumber1AsString);
            Console.Write("Now, enter a number between 1 and 9: ");
            userNumber2AsString = Console.ReadLine();
            userNumber2AsInt = double.Parse(userNumber2AsString);
            percentage = userNumber2AsInt / 10;
            percentageVal = percentage * 100;

            // Perform necessary math on it!
            double userNumberAsPercentage = userNumber1AsInt * percentage;
            Console.WriteLine(
                $"{percentageVal}% of " +                  // Prints out of 100% (20%)
                $"{userNumber1AsString} is " +         // User's chosen starting value (50)
                $"{userNumberAsPercentage}");          // Product (10)

            // Blank line for readable formatting
            Console.WriteLine();

            // Ask user for degrees
            // Tell the user the equivalent number of radians
            // Find the sin of the user's angle
            Console.WriteLine("Great! Now let's determine some trigonometry.");
            Console.Write("Give me a whole angle in degrees, and I'll tell you the sine! ");
            userAngleAsString = Console.ReadLine();
            userAngleAsInt = int.Parse(userAngleAsString);
            userAngleAsDouble = userAngleAsInt * Math.PI / 180;

            Console.WriteLine(
                "Converting to radians... " +                       //
                $"{userAngleAsInt} degrees is " +                   // 60 degrees
                $"{userAngleAsDouble} radians.");      // 1.0471975511965976 radians

            userAngleAsDouble = Math.Round(userAngleAsDouble, 2);

            Console.WriteLine(
                $"The sine of " +
                $"{userAngleAsDouble} radians is " +                   // 1.05 radians
                $"{Math.Round(Math.Sin(userAngleAsDouble), 3)}");                     // 0.866


            // Blank line for readable formatting
            Console.WriteLine();

            // Ask user for their name
            // Change their name by placing the first character on the end
            //   like so:  Charlotte becomes harlotteC
            Console.WriteLine("Lastly, tell me your name!");
            userName = Console.ReadLine().Trim();    // Emily

            for (int i = 0; i < userName.Length - 1; i++)
            {
                newName += userName.Substring(userName.Length) + userName[i + 1];
            }
            newName += userName.Substring(userName.Length) + userName[0];

            //newName = userName.Substring(userName.Length) + userName[1];    // milyE
            Console.WriteLine("I will rename you " + newName + "!");
            Console.WriteLine();

            // Goodbye!
            Console.WriteLine("Thanks for playing my game!  Have a great day " + userName + " !");
        }
    }
}
