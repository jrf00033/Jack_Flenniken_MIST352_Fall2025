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
        get { return _id; }
    }

    public Participant(int id, string name)
    {
        if (id < 0)
        {
            throw new ArgumentOutOfRangeException("id");
            id = _id;
            name = _name;
        }
    }

    //===Constructors

      

    //===Methods===

        


    }

