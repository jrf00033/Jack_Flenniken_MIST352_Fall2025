namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Participant p1 = new Participant(1, "Jack");
            
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
            /*
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
            } */
        }
    } 
}
