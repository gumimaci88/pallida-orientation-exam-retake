using Xunit;
using WareHouse;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace WareHouseIntegrationTest
{
    public class UnitTest
    {
        private TestServer Server;
        private HttpClient Client;

        public UnitTest()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }
        
        [Fact]
        public async Task ReturnOkStatusForWareHouse()
        {
            var response = await Client.GetAsync("/warehouse");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusForSummary()
        {
            var response = await Client.GetAsync("/warehouse/summary");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
