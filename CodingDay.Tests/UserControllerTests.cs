using CodingDay.Models.Users;
using CodingDay.Tests.Configurations;
using CodingDay.Tests.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CodingDay.Tests
{
    public class UserControllerTests
    {
        private const string PUBLIC_USERS = "/public/user";

        private readonly TestServer _server;
        private readonly HttpClient _client;

        public UserControllerTests()
        {
            _server = new TestServer(new WebHostBuilder()
               .UseStartup<TestStartup>());
            _client = _server.CreateClient();
        }

        [Test]
        public async Task TestGetAllUsers()
        {
            var response = await _client.GetAsync(PUBLIC_USERS);

            Assert.IsTrue(response.IsSuccessStatusCode);

            var userDto = await response.GetAsync<List<UserDto>>();

            Assert.AreEqual(userDto.Count, 1);
            Assert.AreEqual(userDto.First().FirstName, "firstname demo");

            //....
        }

        [Test]
        public async Task TestGetUserById()
        {
            var userId = 1;
            var response = await _client.GetAsync($"{PUBLIC_USERS}/{userId}");

            Assert.IsTrue(response.IsSuccessStatusCode);

            var userDto = await response.GetAsync<UserDto>();

            Assert.IsNotNull(userDto.Id);
            Assert.AreEqual(userDto.Id, 1);
            Assert.AreEqual(userDto.FirstName, "firstname demo");
            Assert.AreEqual(userDto.LastName, "lastname demo");
            Assert.AreEqual(userDto.Email, "demo@comerge.net");
        }

        [Test]
        public async Task TestGetNonExistanceUser_ShouldReturnNotFound()
        {
            var userId = 12490325432904;
            var response = await _client.GetAsync($"{PUBLIC_USERS}/{userId}");

            Assert.AreEqual(response.StatusCode, HttpStatusCode.NotFound);
        }
    }
}
