namespace Practice_Methods_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intVal1 = 90, intVal2 = 10; //decalres values
            GreetUser(); //calling method
            Console.WriteLine(SumTwoNumber(100,200)); //calling method
            Console.WriteLine(MultiplyTwoNumbers(intVal1,intVal2));
            AskUserNameAndGreet();

            /*int intTheSum =  SumTwoNumber(intVal1,intVal2); //using the method as a function and storing it in main
            Console.WriteLine(intTheSum);

            Console.WriteLine(SumTwoNumber(100,200));*/
            /*Console.WriteLine(intSum);

            int intMultiply = intVal1 * intVal2; // multiplying ints
            Console.WriteLine(intMultiply); 

            int intDiv = intVal1 / intVal2; //dividing ints
            Console.WriteLine(intDiv);*/
        }
        //a method is a reusable mini program

        /// <summary>
        /// This method calculates the sum of two variables
        /// </summary>
        /// <param name="intFirstVal">First value passed from outside</param>
        /// <param name="intSecondVal">Second value from outside</param>
        /// <returns>The sum of intFirstVal and intSecondVal</returns>
        static int SumTwoNumber(int intFirstVal, int intSecondVal) //if you want yo use this method you need to define 2 variables
            // defined an unvoid method should start with static (data type) (Name, which first character should always be upper case)
        {
            int intSum = intFirstVal + intSecondVal;
            return intSum; //unvoid methods need to return something
        }

        /// <summary>
        /// This greets the user and prints out a nice message
        /// </summary>
        static void GreetUser()
        {
            Console.WriteLine("Hello User.");
        }

        //create a method that accepts two values and multiplies them and returns that
        static int MultiplyTwoNumbers(int X, int Y)
        {
            int intZ = X * Y;
            return intZ;
        }

        //accepts value from the user and prints out a message
        static void AskUserNameAndGreet()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}!");
        }
        static char ObtainLetterGrade(double dblGPA)
        {
            char chrGPA = ' ';
            if (dblGPA <= 90)
                chrGPA = 'A';
            else if (dblGPA <= 80)
                chrGPA = 'B';
            
            return chrGPA;

        }
    }
}
