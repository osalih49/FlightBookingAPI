using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using FlightBookingAPI.Data;
using FlightBookingAPI.Models;

namespace FlightBookingAPI.Services
{
    public class FlightGenerationService
    {
        public List<FlightInstance> GenerateFlightsForNextDays(int days, List<FlightInstance>? existingFlights = null)
        {
            var templates = SeedData.GetTemplates();
            var routes = SeedData.GetRoutes();

            var existingNumbers = new HashSet<string>(
               existingFlights
                   .Where(f => !string.IsNullOrWhiteSpace(f.FlightNumber))
                   .Select(f => f.FlightNumber)
           );
            int nextId = existingFlights.Count == 0 ? 1 : existingFlights.Max(f => f.Id) + 1;

            var newFlights = new List<FlightInstance>();

            var startDate = DateTime.Today;

            foreach (var template in templates)
            {
                var route = routes.FirstOrDefault(r => r.Id == template.RouteId);

                if (route == null)
                {
                    continue;
                }
                for (int i = 0; i < days; i++)
                {
                    var date = startDate.AddDays(i);
                    if (!template.DaysOfWeek.Contains(date.DayOfWeek))
                        continue;

                    foreach (var depStr in template.DepartureTimes)
                    {
                        if (!TimeSpan.TryParseExact(depStr, "hh\\:mm,", CultureInfo.InvariantCulture, out var depTimespan))
                            continue;
                        var departure = date.Date + depTimespan;
                        var arrival = departure.AddMinutes(route.DurationMinutes);

                        var flightNumber = $"R{route.Id}_{departure:yyyyMMdd}_{departure:HHmm}";
                        if (existingNumbers.Contains(flightNumber))
                            continue;

                        var flight = new FlightInstance
                        {
                            Id = nextId++,
                            FlightNumber = flightNumber,
                            RouteId = route.Id,
                            FromCode = route.FromCode,
                            ToCode = route.ToCode,
                            DepartureDateTime = departure,
                            ArrivalDateTime = arrival,
                            Capacity = template.Capacity,
                            SeatsRemaining = template.Capacity,
                            Price = template.BasePrice,
                            Status = "Status"
                        };

                        newFlights.Add(flight);
                        existingFlights.Add(flight);
                    }

                }
            }
            existingFlights.AddRange(newFlights);
            return newFlights;
        }
    }
}