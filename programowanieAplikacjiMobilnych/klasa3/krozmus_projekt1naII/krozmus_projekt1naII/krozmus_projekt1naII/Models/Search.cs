using System;
using System.Collections.Generic;
using System.Text;


namespace krozmus_projekt1naII.Models
{
    public class Search
    {
        public int Id { get; set; }

        public string Location { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public string Details { get; set; }

        public Search(int id, string location, DateTime checkIn, DateTime checkOut)
        {
            Id = id;
            Location = location;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Details = $"From: {checkIn.ToString().Remove(10)}, To: {checkOut.ToString().Remove(10)}";
        }
    }
}
