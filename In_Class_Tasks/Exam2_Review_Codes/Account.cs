using System; //import System namespace for Console and DateTime

public class Account //define Account class
{
    private int _id; //added id parameter
    private string _type; //added type parameter
    private DateTime _createdDate; //added date parameter
    private Customer _customer; //every account has a customer
    private double _balance; //added _balance parameter

    public int ID
    {
        get { return _id; } //return account id
    }

    public string Type
    {
        get { return _type; } //retrieve the parameter
        set
        {
            if (string.IsNullOrEmpty(_type)) //Checking the the account type is empty
            {
                Console.WriteLine("Account type cannot be empty. Value remains previous type"); //Printing warning message
            }
            else
            {
                Type = _type; //If its not empty then its set to the type
            }
        }
    }

    public DateTime Date
    {
        get { return _createdDate; } //retrieve date parameter
        set { Date = _createdDate; } //set Date equal to the current date
    }

    public Customer customer
    {
        get { return _customer; } //retrieve customer parameter
        set
        {
            if (value is null) //check if string is empty
            {
                Console.WriteLine("All Accounts must be linked with a customer."); //Print warning message
            }
            else { customer = _customer; } //set customer equal to _customer
        }
    }

    public Account() //default constructor
    {
        _id = 0; //initialize id to 0
    }

    public void Deposit(double Amount) //Constructor that requires an account balance
    {
        if (_balance > 0) { _balance = Amount; } //if balance > 0, set balance to deposit amount
        else { Console.WriteLine("Depost amount must be greater than 0"); } //print warning if invalid
    }

    public void Close() //creating account close method
    {
        if (_balance == 0) //checking if the balance is 0
        {
            Console.WriteLine("Account Closed"); //Printing Account closed
        }
        else { Console.WriteLine("Active funds remain cannot close account"); } //PRint that active funds are back
    }

    public void AssignCustomer(Customer c) //method to assign customer
    {
        if (_customer is null) //check if current customer is null
        {
            Console.WriteLine("Cusotomer cannot be empty"); //print warning
        }
    }

    public Account(int ID) //constructor with id parameter
    {
        if (_id > 0) //check if id is valid
        {
            ID = _id; //assign id
        }
        else Console.WriteLine("Id must be greater than 0"); //print warning if invalid
    }

    public Account(int ID, string Type) //constructor with id and type parameters
    {
        if (_id > 0) //check if id is valid
        {
            ID = _id; //assign id
        }
        else Console.WriteLine("Id must be greater than 0"); //print warning if invalid

        if (string.IsNullOrEmpty(_type)) //check if type is empty
        {
            Console.WriteLine("Type cannot be empty."); //print warning
        }
        else { Type = _type; } //assign type
    }

    public Account(Customer customer) //constructor with customer parameter
    {
        if (customer is null) //check if customer is null
        {
            Console.WriteLine("Customer cannot be null"); //print warning
        }
        else { customer = _customer; } //assign customer
    }

    public void DisplayInfo() //method to display account info
    {
        Console.WriteLine($"ID:{_id} Type:{_type} Date:{_createdDate} Customer:{_customer} Balance: {_balance}"); //print account details
    }
}