namespace FlightBookingAPI.Models
{
    public class ScheduleTemplate
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public List<string> DepartureTimes { get; set; } = new();
        public List<DayOfWeek> DaysOfWeek { get; set; }

        public int Capacity { get; set; }
        public decimal BasePrice { get; set; }

    }
}
