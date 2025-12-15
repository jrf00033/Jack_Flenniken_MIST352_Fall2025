namespace HW3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Workshop Reservation System.");
            var session = new WorkshopSession("Workspace 1");
            int choice = 0;

            while (choice != 4)
            {
                choice = ShowMenu();


                switch (choice)
                {
                    case 1: // Assign Premium Seat
                        Console.Write("Enter Participant ID: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine();

                        Participant p1 = new Participant(id, name, email);

                        if (!session.AssignPremiumSeat(p1))
                        {
                            Console.Write("Premium is full. Assign Standard instead? (Y/N): ");
                            if (AskYesNo())
                            {
                                if (!session.AssignStandardSeat(p1))
                                {
                                    Console.WriteLine("Next workshop starts in 3 hours.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Next workshop starts in 3 hours.");
                            }
                        }
                        break;

                    case 2: // Assign Standard Seat
                        Console.Write("Enter Participant ID: ");
                        int id2 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string name2 = Console.ReadLine();

                        Console.Write("Enter Email: ");
                        string email2 = Console.ReadLine();

                        Participant p2 = new Participant(id2, name2, email2);

                        if (!session.AssignStandardSeat(p2))
                        {
                            Console.Write("Standard is full. Assign Premium instead? (Y/N): ");
                            if (AskYesNo())
                            {
                                if (!session.AssignPremiumSeat(p2))
                                {
                                    Console.WriteLine("Next workshop starts in 3 hours.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Next workshop starts in 3 hours.");
                            }
                        }
                        break;

                    case 3:
                        session.DisplayAllSeats();
                        break;

                    case 4:
                        // Exit handled by while condition
                        break;

                    case 9:
                        DebugFillAllSeats(session);
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }


        /*var key = "";
        while (key != null)
        {
            var session = new WorkshopSession("Workspace 1");

            ShowMenu();
            Console.Write("Your Choice:");
            key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    var participant = new Participant(1, "Jack");
                    break;

                case "2":

                    break;
                case "3":
                    session.DisplayAllSeats();
                    break;
                case "4":
                    return;
                    break;
                case "9":
                    DebugFillAllSeats(session);
                    break;
            }
        }*/








        /*var session = new WorkshopSession("test");

        DebugFillAllSeats(session);
        session.DisplayAllSeats(); */





        static int ShowMenu()
        {

            Console.WriteLine("Please choose and option:");
            Console.WriteLine("\n1. Assign Premium Seat");
            Console.WriteLine("2. Assign Standard Seat");
            Console.WriteLine("3. Display All Seats");
            Console.WriteLine("4. Exit");
            Console.WriteLine("9. Debug Fill All Seats");
            Console.Write("Choice: ");
            return int.Parse(Console.ReadLine());
        }
        static bool AskYesNo()
        {
            return Console.ReadLine().Trim().ToUpper() == "Y";
        }









        /// <summary>
        /// DEBUG METHOD – Automatically fills all seats in the workshop.
        /// --------------------------------------------------------------
        /// This method is used ONLY for testing and grading. It allows you
        /// to instantly fill all Premium and Standard seats without typing
        /// 20 participants manually.
        ///
        /// HOW IT WORKS:
        /// 1. Starts with ID = 9000 and increments for each debug participant.
        /// 2. While the workshop still has empty seats:
        ///    • If Premium section still has free seats → try Premium first.
        ///    • Otherwise → fill Standard section.
        /// 3. Creates a Participant object with:
        ///       ID    = nextId
        ///       Name  = "Premium_Debug_ID" or "Standard_Debug_ID"
        ///       Email = "premiumID@test.com" or "standardID@test.com"
        /// 4. Attempts to assign the participant to the preferred section:
        ///    - If assignment succeeds → continue.
        ///    - If assignment fails (section just filled):
        ///         • If Premium failed  → try Standard (if not full)
        ///         • If Standard failed → try Premium (if not full)
        /// 5. This logic guarantees:
        ///    - Every seat gets filled.
        ///    - No seat is overwritten.
        ///    - No infinite loops or invalid assignments.
        /// 6. When complete, prints: "DEBUG: All seats auto-filled."
        ///
        /// WHY THIS EXISTS:
        /// • Makes grading MUCH faster (fills full workshop in < 1 second)
        /// • You can test DisplayAllSeats() instantly.
        /// • Allows you to spot layout errors, timestamp issues,
        ///   and booking logic problems immediately.
        ///
        /// PARAMETERS:
        ///   <param name="session">
        ///     The WorkshopSession object the method will operate on.
        ///     Must already be created in Main(). This object contains:
        ///       - The 20 Seat objects
        ///       - All section/row information
        ///       - Seat-booking methods used internally
        ///   </param>
        ///
        /// RETURNS:
        ///   <returns>
        ///     This method does not return a value (void). It updates the state
        ///     of the WorkshopSession object by filling every empty seat with
        ///     auto-generated Participant objects.
        ///   </returns>
        ///
        /// NOTE:
        ///   • Do NOT modify this method.
        ///   • You must enable this by pressing option 9 (or similar) from the menu.
        /// </summary> 

        static void DebugFillAllSeats(WorkshopSession session)
        {
            int nextId = 9000;

            while (!session.IsWorkshopFull())
            {
                bool preferPremium = !session.IsPremiumFull();

                string section = preferPremium ? "Premium" : "Standard";
                Participant p = new Participant(
                    nextId,
                    $"{section}_Debug_{nextId}",
                    $"{section.ToLower()}{nextId}@test.com"
                );

                bool assigned = preferPremium
                    ? session.AssignPremiumSeat(p)
                    : session.AssignStandardSeat(p);

                if (!assigned)
                {
                    if (preferPremium && !session.IsStandardFull())
                        session.AssignStandardSeat(p);
                    else if (!preferPremium && !session.IsPremiumFull())
                        session.AssignPremiumSeat(p);
                }

                nextId++;
            }

            Console.WriteLine("DEBUG: All seats auto-filled.\n");

        }


    }
}
    

