using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Teller
{
    private int _ID;
    private string _Name;
    public string _LastName; //setting variables

    public Teller(int ID, string name) //making a constructor
    {
        _ID = ID;
        _Name = name; //con
        int pos = _Name.LastIndexOf(" ") + 1;
        _LastName = _Name.Substring(pos, _Name.Length - pos);
    }

    public void DisplayInfo() //method to display info
    {
        Console.WriteLine($"{_ID} == {_Name}");
    }

    public void DisplayLastName()
    {
        int pos = _Name.LastIndexOf(" ") + 1;
        Console.WriteLine(_Name.Substring(pos, _Name.Length - pos));
    }

}

