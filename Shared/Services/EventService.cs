using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Services
{
    public class EventService
    {
        private List<Event> events = new List<Event>
        {
            new Event
            {
                Id = 1,
                Name = "Tech Conference 2025",
                Date = new DateTime(2025, 3, 15),
                Location = "San Francisco, CA",
                Description = "A conference about the latest in technology.",
                ImageUrl = "https://example.com/images/tech-conference.jpg"
            },
            new Event
            {
                Id = 2,
                Name = "Music Festival",
                Date = new DateTime(2025, 6, 20),
                Location = "Austin, TX",
                Description = "A festival featuring various music artists.",
                ImageUrl = "https://example.com/images/music-festival.jpg"
            },
            new Event
            {
                Id = 3,
                Name = "Art Expo",
                Date = new DateTime(2025, 9, 10),
                Location = "New York, NY",
                Description = "An expo showcasing modern art.",
                ImageUrl = "https://example.com/images/art-expo.jpg"
            }
        };

        public List<Event> GetMockEvents()
        {
            return events;
        }

        public async Task<List<Event>> GetMockEventsAsync()
        {
            return await Task.FromResult(GetMockEvents());
        }

        public async Task<Event?> GetEventByIdAsync(int eventId)
        {
            return await Task.FromResult(events.FirstOrDefault(e => e.Id == eventId));
        }
    }
}