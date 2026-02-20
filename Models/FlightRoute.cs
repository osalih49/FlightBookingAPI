namespace FlightBookingAPI.Models
{
    public class FlightRoute
    {
        public int Id { get; set; } 
        public string FromCode { get; set; }
        public string ToCode { get; set; }
        public int DurationMinutes { get; set; }

    }
}
