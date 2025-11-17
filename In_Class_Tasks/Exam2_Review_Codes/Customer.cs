using System; //import System namespace for Console and string utilities

public class Customer //define Customer class
{
    private int _customerid; //private field for customer ID
    private string _name; //private field for customer name
    private string _phone; //private field for customer phone number
    private string _email; //private field for customer email
    private string _address; //private field for customer address

    public int ID //public property to expose customer ID
    {
        get { return _customerid; } //return private field _customerid
    }

    public string Name //public property for customer name
    {
        get { return _name; } //return private field _name
        set
        {
            if (string.IsNullOrEmpty(_name)) //check if current name is empty
            {
                Console.WriteLine("Name cannot be empty. Value reamins previous Name"); //print warning
            }
            else { _name = Name; } //assign property value to backing field
        }
    }

    public string Phone //public property for customer phone
    {
        get { return _phone; } //return private field _phone
        set
        {
            if (string.IsNullOrEmpty(_phone)) //check if current phone is empty
            {
                Console.WriteLine("Phone number set to empty string by default"); //print warning
                Phone = ""; //set phone to empty string
            }
            else { _phone = Phone; } //assign property value to backing field
        }
    }

    public string Email //public property for customer email
    {
        get { return _email; } //return private field _email
        set
        {
            if (string.IsNullOrEmpty(_email) || !_email.Contains('@')) //validate email is not empty and contains '@'
            {
                Console.WriteLine("Email cannot be empty or missing '@' symbol. Defaulting to John.Smith@gmail.com"); //print warning
                _email = "John.Smith@gmail.com"; //set default email
            }
            else { Email = _email; } //assign property value to backing field
        }
    }

    public string Address //public property for customer address
    {
        get { return _address; } //return private field _address
        set
        {
            if (string.IsNullOrEmpty(_address)) //check if current address is empty
            {
                Console.WriteLine("No error: just sets empty."); //print message
                _address = ""; //set address to empty string
            }
            else { _address = Address; } //assign property value to backing field
        }
    }

    //Constructor with id and name parameters
    public Customer(int id, string name)
    {
        _phone = Phone; //initialize phone field with property value
        _email = Email; //initialize email field with property value
        _address = Address; //initialize address field with property value

        if (_customerid <= 0) //validate customer ID
        {
            Console.WriteLine("CustomerID must be > 0. Defaulting to 1."); //print warning
            _customerid = 1; //set default ID
        }
        else { id = _customerid; } //assign field to parameter

        if (string.IsNullOrEmpty(_name)) //validate name
        {
            Console.WriteLine("Name required. Defaulting to John Smith"); //print warning
            _name = "John Smith"; //set default name
        }
        else { name = _name; } //assign field to parameter
    }

    //Constructor with id, name, and email parameters
    public Customer(int id, string name, string email)
    {
        _phone = Phone; //initialize phone field with property value
        _address = Address; //initialize address field with property value

        if (_customerid <= 0) //validate customer ID
        {
            Console.WriteLine("CustomerID must be > 0. Defaulting to 1."); //print
        }
    }
}