using System;
using System.Collections.Generic;
using FlightBookingAPI.Models;


namespace FlightBookingAPI.Data
{
    public static class SeedData
    {
        public static List<Airport> GetAirports() 

        {
            return new List<Airport>
            {
                new Airport { Code = "DTW", City = "Detroit", Name = "Detroit Metro" },
                new Airport { Code = "JFK", City = "New York", Name = "JFK International"},
                new Airport { Code = "MCO", City = "Orlando", Name = "Orlando International"},
                new Airport { Code = "ORD", City = "Chicago", Name = "CHicago O'Hare International"},
                new Airport { Code = "ATL", City = "Atlanta", Name = "Hartsfield-Jackson Atlanta International"},
                new Airport { Code = "DFW", City = "Dallas", Name = "Dallas/Fort Worth International"}
            };
        }

        public static List<FlightRoute> GetRoutes()
        {
            return new List<FlightRoute>
            {
                new FlightRoute {Id = 1, FromCode = "DTW", ToCode = "JFK", DurationMinutes = 120},
                new FlightRoute {Id = 2, FromCode = "DTW", ToCode = "MCO", DurationMinutes = 139},
                new FlightRoute {Id = 3, FromCode = "DTW", ToCode = "ORD", DurationMinutes = 90},
                new FlightRoute {Id = 4, FromCode = "DTW", ToCode = "ATL", DurationMinutes = 130},
                new FlightRoute {Id = 5, FromCode = "DTW", ToCode = "DFW", DurationMinutes = 190}
            };

        }
        public static List<ScheduleTemplate> GetTemplates()
        {
            var allDays = new List<DayOfWeek>
            {
                DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, 
                DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday
            };
            return new List<ScheduleTemplate>
            {
                new ScheduleTemplate
                {
                    Id = 1,
                    RouteId = 1,
                    DepartureTimes = new List<string> { "06:15", "12:30", "18:45" },
                    DaysOfWeek = allDays,
                    Capacity = 100,
                    BasePrice = 179m
                },

                new ScheduleTemplate
                {
                    Id = 2,
                    RouteId = 2,
                    DepartureTimes = new List<string> { "07:30", "14:05", "20:20" },
                    DaysOfWeek = allDays,
                    Capacity = 100,
                    BasePrice = 179m
                },

                 new ScheduleTemplate
                {
                    Id = 3,
                    RouteId = 3,
                    DepartureTimes = new List<string> { "05:50", "11:25", "16:45" },
                    DaysOfWeek = allDays,
                    Capacity = 100,
                    BasePrice = 179m
                },
                  new ScheduleTemplate
                {
                    Id = 4,
                    RouteId = 4,
                    DepartureTimes = new List<string> { "06:45", "15:10", "19:30" },
                    DaysOfWeek = allDays,
                    Capacity = 100,
                    BasePrice = 179m
                },
                   new ScheduleTemplate
                {
                    Id = 5,
                    RouteId = 5,
                    DepartureTimes = new List<string> { "08:20", "13:55", "21:15" },
                    DaysOfWeek = allDays,
                    Capacity = 100,
                    BasePrice = 179m
                },
            };
        }
    }
}
