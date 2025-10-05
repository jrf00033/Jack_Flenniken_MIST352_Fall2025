using System.ComponentModel.Design;



/*
 * Author: Jack Flenniken
 * Date: 10/5/2025
 * Purpose: switch loops
 */
namespace Practice_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] strNames = { "Sarah", "Ahmad", "Jack", "Maddie", "Duncan", "Hayden", "Sam", "Tyler" };
            char chrUserChoice = 'A';
            while (chrUserChoice != 'X')
            {
                WelcomeMessageAndOptions();
                chrUserChoice = Console.ReadKey().KeyChar; //reads just a key

                switch (chrUserChoice) //best used when searching for a char
                {
                    case 'A': //if A then basically
                        Console.WriteLine("\nOk this will print out the name in the array");
                        PrintOutNames(strNames);
                        break;
                    case 'B':
                        Console.WriteLine("\nOk this will search for a name in the array");
                        Console.WriteLine("\nGive me a name to search for");
                        string strNameToSearchFor = Console.ReadLine();
                        bool nameFound = false;

                        for (int i = 0; i < strNames.Length; i++)
                            if (strNameToSearchFor == (strNames[i])) //searching each input if it has the name
                            {
                                SearchForName(strNameToSearchFor, strNames);
                                nameFound = true; //if the name is found the bool is made true
                                break;
                            }

                        if (!nameFound) //if name found is still false then print
                        {
                            Console.WriteLine("This name is not listed.");
                        }
                        break;



                        /*for (int index = 0; index < strTheNamesArray.Length; index++)
                        {
                            if (strTheNamesArray[index].Equals(strTheNameToFind)) //matching elements from arrays
                            {
                                Console.WriteLine($"The Name {strTheNameToFind} found at location {index}");
                            }
                        }*/


                        break;
                    case 'X':
                        break;
                    default://anything that isnt a case is default
                        Console.WriteLine("\nInvalid Input. Try again");
                        break;
                }


            }


        }

        static void WelcomeMessageAndOptions() //non void static
        {
            Console.WriteLine("Welcome. Choose an option below.");
            Console.WriteLine("A - printout all names\nB - Search for name in the array\nX Exit the program");
        }
        /// <summary>
        /// Printout the contents of a given array
        /// </summary>
        /// <param name="strNames">The array of data coming from outside</param>
        static void PrintOutNames(string[] strNames) //printsout the array names
        {
            for (int index = 0; index < strNames.Length; index++)
            {
                Console.WriteLine(strNames[index]);
            }
        }
        /// <summary>
        /// Finds and reports the location of a given name in the give array of names
        /// </summary>
        /// <param name="strTheNameToFind">The name to find in the array (external)</param>
        /// <param name="strTheNamesArray">THe array of names to search in (external)</param>
        static void SearchForName(string strTheNameToFind, string[] strTheNamesArray)
        {
            for (int index = 0; index < strTheNamesArray.Length; index++)
            {
                if (strTheNamesArray[index].Equals(strTheNameToFind)) //matching elements from arrays
                {
                    Console.WriteLine($"The Name {strTheNameToFind} found at location {index}");
                }
            }
        }
    }
}
