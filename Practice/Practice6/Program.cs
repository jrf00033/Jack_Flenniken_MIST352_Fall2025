namespace Practice6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*double[] dblNumbers = { 19.0, 18, 10, 0.7, 5.5 };
            for (int i = 0; i < dblNumbers.Length; i++)
            {
                Console.WriteLine(dblNumbers[i]);
            }

            int intWhileIndex = 0;
            while (intWhileIndex < dblNumbers.Length)
            {
                Console.WriteLine(dblNumbers[intWhileIndex]);
                intWhileIndex++;
            }*/

            String strMagicWord = "";
            Console.WriteLine("what is 5 * 5?");
            while (strMagicWord!= "25") //allow you to lock user in while loop until they give you a correct answer
            {
                Console.WriteLine("Wrong answer. Try again");
                strMagicWord = Console.ReadLine();
            }
        }
    }
}
