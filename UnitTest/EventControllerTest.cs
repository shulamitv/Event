using lesson2_calendar;
using lesson2_calendar.Controllers;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace lesson2_calendar.UnitTest
{
    public class EventControllerTest
    {
        private readonly EventController _controller;
        private readonly IdataContext _idatacontext;
        public EventControllerTest()
        { 
            _idatacontext = new FakeContext();
            _controller = new EventController(_idatacontext);  
        }


        [Fact]
        public void GetOkRusult(object assert)
        {
            var result = _controller.Get();
            Assert.IsType<OkResult>(result);
        }
    }
}
