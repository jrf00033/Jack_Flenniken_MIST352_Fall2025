/*
 * Jack Flenniken
 * 9/4/2025
 * In class practice
 */


namespace Practice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String strData = "          jack ramsey flenniken      ";
            Console.WriteLine(strData.Length);
            Console.WriteLine($"The original name is {strData}");
            //remove spaces before and after name
            //strData = strData.Trim();
            //Console.WriteLine(strData);
            //Console.WriteLine(strData.Length);
            
            //This removes spaces before and after and makes everything lower case
            Console.WriteLine(strData.ToLower().Trim());

            //This makes everything upper case
            Console.WriteLine(strData.ToUpper());

            //This 
            
            String strProcessedName = strData.Trim(); 
            //defining the string and trimming the space from front and back
            
            Console.WriteLine($"Processed name is: {strProcessedName}");
            //showing the line we are processing in the console
            
            Console.WriteLine(strProcessedName.IndexOf('a'));
            //listing the number of characters starting (0,1,2,3,4...) until the first occurence of defined character (a)

            Console.WriteLine(strProcessedName.Substring(5,3));
            //prints out 3 the characters after the 5th character

            //lets find and print out the first name
            int intFirstSpace = strProcessedName.IndexOf(" "); //storing the integer where the first space is
            Console.WriteLine(strProcessedName.Substring(0, intFirstSpace)); //printing out the first name stopping at the first space

            //lest print out the middle name
            int intLastSpace = strProcessedName.LastIndexOf(" "); //finding the last space
            Console.WriteLine($"First space is at location {intFirstSpace} and last space is at {intLastSpace}");
            int intMidNameLength = intLastSpace - intFirstSpace;//calculating the middle name length
            Console.WriteLine(strProcessedName.Substring(intFirstSpace,intMidNameLength));

            //print out the last name
            Console.WriteLine(strProcessedName.Substring(intLastSpace+1)); //printing all characters from the second space, +1 starting at +1 integer and prints out the rest

            //Lets try making first char of middle name upper case
            String strMidName = strProcessedName.Substring(intFirstSpace+1,intMidNameLength); //defining middle name in a string
            Console.WriteLine($"Middle Name is {strMidName}"); 
            Console.WriteLine(String.Concat("OP", "LO")); // concat lets you combine two sets of text together
            char chrMidInitial = 'O';// defining characters
            char chrOtherChar = 'K';
            string strCombinedChar =String.Concat(chrMidInitial,chrOtherChar, "howdy"); //combining diff defined strings
            Console.WriteLine(strCombinedChar);

            Console.WriteLine(strMidName.Substring(0,1).ToUpper());
            //printing the first char of the name

            Console.WriteLine(strMidName.Substring(1).ToLower());
            //printing out everything after first char



        }
    }
}
