/*
 * Author: Jack Flenniken
 * Date: 9/8/2025
 * About: A program that asks for information about a hero and prints out prompts for a quest
 */
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Printing a text prompt
            Console.WriteLine("What is your hero's name?:");
            String heroName = Console.ReadLine();
            //Printing a text prompt
            Console.WriteLine("What is your Favorite Place?:");
            String favoritePlace = Console.ReadLine();
            //Printing a text prompt
            Console.WriteLine("What is your lucky number?:");
            //defining a string
            String luckyNumberText = Console.ReadLine();

            //trimming a string
            heroName = heroName.Trim();
            //trimming a string
            favoritePlace = favoritePlace.Trim();
            //defining integer
            int luckyNumber = int.Parse(luckyNumberText);
            //defining a boolean
            bool numCheck;
            //using boolean to check if value is full
            numCheck = int.TryParse(luckyNumberText, out luckyNumber);

            //Printing text
            String line1 = "Meet " + heroName + "!";
            //defining a string
            String line2 = "Today's quest starts in " + favoritePlace + ".";
            //defining a string
            String line3 = "Lucky Number: " + luckyNumber;
            //defining a string
            String nick = heroName.Substring(0, 3).ToUpper();
            //defining a string
            String code = "#" + nick + "-" + luckyNumber;

            //defining a string
            String report = $"{line1}\n{line2}\n{line3}\nQuestCode: {code}";

            //Printing text
            Console.WriteLine(report);
            //Printing text
            Console.WriteLine("Parse Success: " + numCheck);
            //Printing text
            Console.WriteLine("Hero length: " + heroName.Length);
            //Printing text
            Console.WriteLine("Place contains a space: " + (favoritePlace.IndexOf(' ') >= 0));



        }
    }
}
