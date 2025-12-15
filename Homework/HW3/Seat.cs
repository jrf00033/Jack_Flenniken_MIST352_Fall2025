using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Seat  
{
    //===fields===
    private int _rowNumber;
    private int _seatNumber;
    private string _sectionType;
    private bool _isBooked;
    private Participant _assignedParticipant;
    private DateTime _reservationTime;
   //===properties===
   public int RowNumber 
    {  get { return _rowNumber; } } //returning row number
    public int SeatNumber 
    { get { return _seatNumber; } } //returning seat number
    public string SectionType 
    {  get { return _sectionType; } } //returning section type
    public bool IsBooked 
    { 
        get { return _isBooked; } //returning the isBooked bool
        set { _isBooked = false; } //setting booked bool to false
    }

    public Participant AssignedParticipant 
    { 
        get { return _assignedParticipant; } //returning the participant
        set { _assignedParticipant = null; } //setting value to null
    }

    public DateTime ReservationTime
    {
        get { return _reservationTime; } //returning reservation time
        set { _reservationTime = default; } //setting res time to default
    }

    //===constructors===

    public Seat(int rowNumber, int seatNumber, string sectionType) //constructor using row, seat, and section
    {
        if (!(rowNumber <= 10 && rowNumber >= 1 )) //checking if row number is not between 1 and 10
        {
            throw new ArgumentException("Row Number must be between 1 and 10");//stop program and print warning
        }

        if (seatNumber != 1 && seatNumber != 2) //checking if seat number is 1 or 2
        {
            throw new ArgumentException("Seat Number must be 1 or 2");//stop program and print warning
        }

        if (sectionType != "Premium" && sectionType != "Standard") //checking if sectiontype is not equal to Premium and Standard
        {
            throw new ArgumentException("Section Type must be Premium or Standard"); //stop program and print warning
        } 

        _rowNumber = rowNumber; //setting equal to input
        _seatNumber = seatNumber; //setting equal to input
        _sectionType = sectionType; //setting equal to input

    }

    //===methods===

    public void DisplayInfo() //method to display participants info
    {
        
        Console.WriteLine($"Se name is {_rowNumber}, ID is {_seatNumber}, and email is {_sectionType}"); //displays participants info
    }

    public bool AssignParticipant(Participant participant)
    {
        if ( _isBooked != false ) //Checking if _isBooked seat is true or false
        {
            throw new ArgumentException("Seat is booked"); //Stopping code and showing error
        }
        _isBooked= true; //setting seat booked to true
        _reservationTime = DateTime.Now; //setting reservation time to the time seat is booked
        _assignedParticipant = participant; //assigning participant to seat

        return true;
    }

    public void GetSeatStatus() //method to check the status of seats
    {
        if (_isBooked = false) //checking if seat is false
        {
            Console.WriteLine("FREE"); //Printing Free
        }
        Console.WriteLine($"Booked by {_assignedParticipant.Name} at {_reservationTime} "); //Printing seat info
    }


    

}
