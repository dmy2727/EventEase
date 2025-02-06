using Microsoft.AspNetCore.Components;
using Shared.Models;
using Shared.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventEase_app.Pages
{
    public partial class EventList : ComponentBase
    {
        [Inject]
        private EventService? EventService { get; set; }

        [Inject]
        private NavigationManager? Navigation { get; set; }

        private List<Event> events = new List<Event>();

        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine("EventList: OnInitializedAsync called");
            if (EventService != null)
            {
                events = await EventService.GetMockEventsAsync();
                Console.WriteLine("EventList: Events loaded");
            }
        }

        protected override void OnParametersSet()
        {
            Console.WriteLine("EventList: OnParametersSet called");
        }

        protected override void OnAfterRender(bool firstRender)
        {
            Console.WriteLine($"EventList: OnAfterRender called, firstRender = {firstRender}");
        }

        private void NavigateToEventDetails(int eventId)
        {
            if (Navigation != null)
            {
                Navigation.NavigateTo($"/eventdetails/{eventId}");
                Console.WriteLine($"EventList: Navigating to event details for eventId = {eventId}");
            }
        }
    }
}

