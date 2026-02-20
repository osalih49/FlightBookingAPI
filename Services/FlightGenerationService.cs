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

            var existingNumber = new HashSet<string>(existingFlights .Where(f = >);
        }
    }
}