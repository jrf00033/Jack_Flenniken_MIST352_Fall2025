using System;
using System.Collections.Generic;
using System.Linq;

namespace SeatingSystem
{
    class Program
    {
        static void Main()
        {
            WorkshopSession workshop = new WorkshopSession("MT532 Workshop");

            while (true)
            {
                Console.WriteLine("\n1) Assign Premium seat");
                Console.WriteLine("2) Assign Standard seat");
                Console.WriteLine("3) Display all seats");
                Console.WriteLine("0) Exit");
                Console.Write("Your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                    continue;

                switch (choice)
                {
                    case 1:
                        AssignSeat(workshop, "Premium");
                        break;
                    case 2:
                        AssignSeat(workshop, "Standard");
                        break;
                    case 3:
                        workshop.DisplayAllSeats();
                        break;
                    case 0:
                        return;
                }
            }
        }

        static void AssignSeat(WorkshopSession workshop, string section)
        {
            int id;
            Console.Write("Enter ID: ");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid ID.");
                Console.Write("Enter ID: ");
            }

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if (!email.Contains("@"))
            {
                Console.WriteLine("Invalid email.");
                return;
            }

            Participant participant = new Participant(id, name, email);

            bool success = workshop.AssignSeat(participant, section);

            Console.WriteLine(success
                ? $"{section} seat assigned."
                : $"No {section} seats available.");
        }
    }

    // =======================
    // Participant
    // =======================
    class Participant
    {
        public int ID { get; }
        public string Name { get; }
        public string Email { get; }

        public Participant(int id, string name, string email)
        {
            ID = id;
            Name = name;
            Email = email;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} (ID {ID})");
        }
    }

    // =======================
    // Seat
    // =======================
    class Seat
    {
        public int RowNumber { get; }
        public int SeatNumber { get; }
        public string SectionType { get; }
        public bool IsBooked { get; private set; }
        public Participant AssignedParticipant { get; private set; }
        public DateTime? ReservationTime { get; private set; }

        public Seat(int row, int seatNumber, string section)
        {
            RowNumber = row;
            SeatNumber = seatNumber;
            SectionType = section;
            IsBooked = false;
        }

        public bool AssignParticipant(Participant participant)
        {
            if (IsBooked)
                return false;

            AssignedParticipant = participant;
            ReservationTime = DateTime.Now;
            IsBooked = true;
            return true;
        }

        public override string ToString()
        {
            if (IsBooked)
            {
                return $"Row {RowNumber}, Seat {SeatNumber} ({SectionType}) - " +
                       $"TAKEN by {AssignedParticipant.Name} (ID {AssignedParticipant.ID}) at {ReservationTime}";
            }

            return $"Row {RowNumber}, Seat {SeatNumber} ({SectionType}) - FREE";
        }
    }

    // =======================
    // WorkshopSession
    // =======================
    class WorkshopSession
    {
        private readonly List<Seat> seats = new List<Seat>();
        public string Name { get; }

        public WorkshopSession(string name)
        {
            Name = name;
            InitializeSeats();
        }

        private void InitializeSeats()
        {
            // Premium seats: Rows 1–5, Seats 1–2
            for (int row = 1; row <= 5; row++)
                for (int seat = 1; seat <= 2; seat++)
                    seats.Add(new Seat(row, seat, "Premium"));

            // Standard seats: Rows 6–10, Seats 1–2
            for (int row = 6; row <= 10; row++)
                for (int seat = 1; seat <= 2; seat++)
                    seats.Add(new Seat(row, seat, "Standard"));
        }

        public bool AssignSeat(Participant participant, string section)
        {
            Seat availableSeat = seats
                .FirstOrDefault(s => !s.IsBooked && s.SectionType == section);

            return availableSeat != null && availableSeat.AssignParticipant(participant);
        }

        public void DisplayAllSeats()
        {
            Console.WriteLine($"\nWorkshop: {Name}\n");

            foreach (Seat seat in seats)
                Console.WriteLine(seat);

            Console.WriteLine(new string('-', 50));
        }
    }
}
