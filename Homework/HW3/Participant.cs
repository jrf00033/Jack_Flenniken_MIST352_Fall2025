using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


public class Participant
{
    //===fields===
    private int _id;
    private string _name;
    private string _email;

    //===properties===
    public int ID //we only want ID to be seen not changed
    {
        get { return _id; } //getting ID
    }

    public string Name
    {
        get { return _name; } //getting name
        set { _name = value; } //allowing the value to be changed
    }

    public string Email
    {
        get { return _email; } //getting email
        set { _email = value; } //allowing the value to be changed
    }






    //===Constructors
    public Participant(int id, string name) //constructor to create participant with id and name
    {
        if (id < 0) //check if the id is greater than 0
        {
            throw new ArgumentOutOfRangeException("id"); //if the ID is less than 0 stop the program
        }
        if (string.IsNullOrWhiteSpace(name)) //check if name is empty
        {
            throw new ArgumentException("Name cannot be empty."); //if the name is empty stop the program
        }
        _id = id; //set input id equal to id
        _name = name; //set participant name to set name
        _email = "N/A"; //set email to N/A
    }
    public Participant(int id, string name, string email) //constructor requiring id, name, and string 
    {
        if (id < 0) //check if id is greater than 0
        {
            throw new ArgumentOutOfRangeException("id"); //if id is not greater than 0 stop the program
        }
        if (string.IsNullOrWhiteSpace(name)) //check if name is empty
        {
            throw new ArgumentException("Name cannot be empty."); //if the name is empty stop the program
        }
        if (!email.Contains('@')) //check if email contains @
        {
            throw new ArgumentException("Email does not contain @."); //if email does not contain @ stops the program
        }

        _id = id; //set the id
        _name = name; //set the name
        _email = email; //set the email

    }


    //===Methods===

    public void DisplayInfo() //method to display participants info
    {
        Console.WriteLine($"Participant's name is {_name}, ID is {_id}, and email is {_email}"); //displays participants info
    }   




}

