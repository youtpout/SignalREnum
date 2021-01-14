using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestLibrary;

namespace SignalREnum.Hubs
{
    public class TestHub : Hub
    {
        public TestHub()
        {
        }

        public async Task Get()
        {
            var user = new User()
            {
                Name = "Test",
                Age = 25,
                Status = UserEnum.Student
            };

            await Clients.Caller.SendAsync("UserLoaded", user);
        }

        public async Task GetNoEnum()
        {
            var user = new UserNoEnum()
            {
                Name = "Test no enum",
                Age = 32
            };

            await Clients.Caller.SendAsync("UserNoEnumLoaded", user);
        }
    }
}
