namespace FlightBookingAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public string PassengerName { get; set; }
        public int Seats { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
