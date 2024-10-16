namespace _07._04_Zadanie_prtaktyczne___pokrywanie_się_dat;

class Program
{
    static void Main(string[] args)
    {
        var bookedRecervations = GetBookedReservations();
        DisplayReservations(bookedRecervations);

        Console.WriteLine("Insert new booking start date: (yyyy-MM-dd)");

        string startDateString = Console.ReadLine();
        DateTime startDate = DateTime.ParseExact(startDateString, "yyyy-MM-dd", null);

        Console.WriteLine("Insert new booking end date: (yyyy-MM-dd)");

        string endDateString = Console.ReadLine();
        DateTime endDate = DateTime.ParseExact(endDateString, "yyyy-MM-dd", null);

        bool isNewReservationPossible = IsNewReservationPossible(startDate, endDate, bookedRecervations);

        if (isNewReservationPossible)
        {
            Console.WriteLine("Reservation booked");
        }
        else
        {
            Console.WriteLine("Select other booking dates");
        }
    }

    static bool IsNewReservationPossible(DateTime startDate, DateTime endDate, List<Reservation> bookedReservations)
    {
        //TODO: Implement the logic
        foreach (var bookedReservation in bookedReservations)
        {
            if (startDate.Date >= bookedReservation.From.Date && startDate <= bookedReservation.From.Date
            || endDate.Date >= bookedReservation.From.Date && endDate <= bookedReservation.From.Date)
            {
                return false;
            }

            if (startDate.Date <= bookedReservation.From.Date && endDate.Date >= bookedReservation.To.Date)
            {
                return false;
            }
        }

        return true;
    }

    static void DisplayReservations(List<Reservation> bookedReservations)
    {
        Console.WriteLine("Booked reservations:");
        foreach (var bookedReservation in bookedReservations)
        {
            Console.WriteLine($"From: {bookedReservation.From.ToString("yyyy-MM-dd")}");
        }
    }

    static List<Reservation> GetBookedReservations()
    {
        var reservations = new List<Reservation>()
        {
            new Reservation(new DateTime(2021, 6, 10), new DateTime(2021, 6, 12)),
            new Reservation(new DateTime(2021, 6, 19), new DateTime(2021, 6, 20)),
            new Reservation(new DateTime(2021, 6, 24), new DateTime(2021, 6, 26)),
            new Reservation(new DateTime(2021, 7, 24), new DateTime(2021, 7, 25)),
        };

        return reservations;
    }
}
