namespace FlightBookingAPI.Models
{
    public class FlightInstance
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public int RouteId { get; set; }
        public string FromCode { get; set; }
        public string ToCode { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public int Capacity { get; set; }
        public int SeatsRemaining { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }

    }
}
