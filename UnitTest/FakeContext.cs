namespace lesson2_calendar.UnitTest
{
    public class FakeContext:IdataContext
    {
        public List<Event> Events { get; set; }

        public FakeContext()
        {
            Events = new List<Event>
            {
                new Event { Id = 1, Title = "Wedding"/*, Start = DateTime.Now*/ },
                new Event { Id = 2, Title = "Appointment"/*, Start = DateTime.Now.AddDays(2)*/}
            };
        }
    }
}
