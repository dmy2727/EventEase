using System;

namespace Shared.Models
{
    public class Event
    {
        public int Id { get; set; }
        public required string Name { get; set; } // Add the required modifier
        public DateTime Date { get; set; }
        public required string Location { get; set; } // Add the required modifier
        public required string Description { get; set; } // Add the required modifier
        public required string ImageUrl { get; set; } // Add the required modifier
    }
}