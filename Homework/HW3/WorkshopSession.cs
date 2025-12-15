using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WorkshopSession
{
    //===fields===
    private Seat[] _seats; //create an array of 20 Seats
    private Participant _participant;
    private string _name;
    private int _maxSeats;
    private Participant _assignedParticipant;
    //===properties===
    public Seat[] Seats { get { return _seats; } }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int MaxSeats
    {
        get { return _maxSeats; }
        set { _maxSeats = value; }

    }

    public Participant AssignedParticipant
    {
        get { return _assignedParticipant; } //returning the participant
        set { _assignedParticipant = null; } //setting value to null
    }


    //===constructors===
    public WorkshopSession(string Name)
    {
        _name = Name; //name is equal to input name

        int rows = 10; //created rows int and set equal to 10
        int seatsPerRow = 2; //created seats int and set equal to 10

        _maxSeats = rows * seatsPerRow; //setting maxSeats equal to rows times seats
        _seats = new Seat[MaxSeats]; //creating an array of 20 seats

        int index = 0; //setting index to start at 0
        for (int r = 1; r <= rows; r++) //starts at row 1 and moves through row 10
        {
            for (int s = 1; s <= seatsPerRow; s++) //starts at seat 1 and goes through seat 2
            {
                string section = (r <= 5) ? "Premium" : "Standard"; //if the row is less than or equal to 5 it becomes premium, else standard
                _seats[index++] = new Seat(r, s, section); //creates new seat with the input

            }
        }

    }

    private int FindFirstAvailableSeat(int startRow, int endRow)
    {
        for (int i = 0; i < _seats.Length; i++)
        {
            var seat = _seats[i];
            if (seat.RowNumber >= startRow && seat.RowNumber <= endRow && !seat.IsBooked)
                return i;
        }
        return -1;
    }


    //===methods===
    public bool AssignPremiumSeat(Participant participant)
    {

        if (participant == null) throw new ArgumentNullException(nameof(participant)); //method to assign premium seat

        int idx = FindFirstAvailableSeat(1, 5); //searching rows 1-5 for a seat
        if (idx == -1) return false; //if there isnt a seat set idx to -1 and returns false

        return _seats[idx].AssignParticipant(participant); //if there is a seat it assigns a participant to the seat
    }

    public bool AssignStandardSeat(Participant participant) //method to Assign a standard seat
    {
        if (participant == null) throw new ArgumentNullException(nameof(participant)); //check if particpant is null

        int idx = FindFirstAvailableSeat(6, 10); //checks rows 6-10 for an available seat
        if (idx == -1) return false; //if seats are full returns false

        return _seats[idx].AssignParticipant(participant); //Assign participant a seat

    }

    public bool IsPremiumFull()
    {
        int idx = FindFirstAvailableSeat(1, 5); //Runs method to check for a seat in premium
        return idx == -1; //sets idx to -1 making it return false
    }

    public bool IsStandardFull()
    {
        int idx = FindFirstAvailableSeat(6, 10);
        return idx == -1;
    }

    public bool IsWorkshopFull()
    {
        int idx = FindFirstAvailableSeat(1, 10);
        return idx == -1;
    }

    public void DisplayAllSeats()
    {
        

        Console.WriteLine("===============================================================================");
        for (int i = 0; i < _seats.Length; i++)
        {
            var seat1 = _seats[i];
            if (seat1.IsBooked)
            {
                Console.WriteLine(
                $"Row {seat1.RowNumber}, Seat {seat1.SeatNumber} ({seat1.SectionType}) - " +
                $"TAKEN by {seat1.AssignedParticipant.Name} (ID {seat1.AssignedParticipant.ID}) " +
                $"at {seat1.ReservationTime}"
            );
            } else

                Console.WriteLine($"Row: {seat1.RowNumber}, Seat {seat1.SeatNumber} ({seat1.SectionType}) - {seat1.IsBooked}");

        }
        Console.WriteLine("===============================================================================");
    }
}




