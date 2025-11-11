using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Bank
{
    public int _ID; //setting the parameters
    public string _Name; //setting the parameters
    public string _Location; //setting the parameters
    public Teller[] _Tellers = new Teller[100]; //creating an array of objects teller

    public void DisplayInfo()
    {
        Console.WriteLine($"{_ID} {_Name} {_Location}");

    }

    public string Name 
    {
        get { return _Name; } //if you want people to be able to see the name you need get
        // set { Name = value; } //if you want people to be able to change the name you use set
        
    }

    public Bank(int ID, string name, string location) //creating a constructor
    {
        this._ID = ID; //setting ID input with constructor equal to ID
        this._Location = location; //setting location input with constructor equal to location
        this._Name = name; //setting name input with constructor equal to name
    }


}




