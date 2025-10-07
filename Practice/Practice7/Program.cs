namespace Practice7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int[] intValues = { 11, 21, 13 };
            Console.WriteLine($"Before {intValues[0]}");
            PrintArray(intValues);
            Console.WriteLine($"After {intValues[0]}");
            //arrays are always passed by method so defining it in a method will change the value*/

            int intFirstVal = 1, intSecondVal = 2, intThirdVal; //defining ints


            Console.WriteLine($"Before Method {intFirstVal} {intSecondVal}");
            Multiply(ref intFirstVal, intSecondVal);
            //need ref with the value when calling it
            Console.WriteLine(Multiply_Return(ref intFirstVal, intSecondVal));
            //Second method doesn't print it out this how we call it
            Console.WriteLine($"After Method {intFirstVal} {intSecondVal}");
            //showing that the value stays the same before and after the method

            Sum(ref intFirstVal, intSecondVal,out intThirdVal);
        }


        //passing by reference
        static void Multiply(ref int intVal1, int intVal2)
        //ref means that this value will be passed by reference, meaning that if the value is modified here the original value is modified too
        {
            intVal1 = 100; //this is a pass by value
            intVal2 = 0; //no ref so after the method the value is 2 as coded above
            Console.WriteLine(intVal1 * intVal2); //promoting values
        }

        static int Multiply_Return(ref int intVal1, int intVal2)
        {
            intVal1 = 200;
            intVal2 = 0;
            return intVal1 * intVal2; //this doesnt write it
        }

        static void Sum(ref int x, int y, out int z) 
        //difference between ref and out is ref needs to be intialized and declared in the main method
        {
            x = 10;
            z = 20; //you have to modify a value when you use out, you are expecting the method to modify that value

            Console.WriteLine(x + y + z);
        }

        static void PrintArray(int[] intData)
        {
            intData[0] = 1000; //sets the value inside the method to 1000
            for (int i = 0; i < intData.Length; i++)
            {

                Console.WriteLine(intData[i]);
            }
        }

    }

}
