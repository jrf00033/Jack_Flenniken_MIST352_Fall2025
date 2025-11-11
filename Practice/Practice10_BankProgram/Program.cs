namespace Practice10_BankProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Bank WVU = new Bank(101,"WVU","Morgantown, WV"); //creating a new object of bank class
            WVU.DisplayInfo(); //Displaying info of the WVU object
            Console.WriteLine(WVU.Name);
            WVU._Location = "Huntington, WV";
            WVU.DisplayInfo();

            Teller teller1 = new Teller(201, "Jack Flenniken");
            Teller teller2 = new Teller(800, "Sarah Smith");

            WVU._Tellers[0] = teller1;
            WVU._Tellers[1] = teller2; //inputing tellers into an array

            Console.WriteLine(WVU._Tellers[0]._LastName);

            teller1.DisplayInfo(); //calling method
            teller1.DisplayLastName(); //calling method to get last name
            Console.WriteLine($"The last name is {teller1._LastName}"); //extrating info of last name stored



            
        }
    }
}
