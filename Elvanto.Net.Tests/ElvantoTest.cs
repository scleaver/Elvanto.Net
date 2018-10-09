using Elvanto.Net.Interfaces;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Elvanto.Net.Tests
{
    public abstract class ElvantoTest
    {
        protected IElvantoManager ElvantoManager;

        private string _apikey = "add-your-api-key-to-client-secrest.json";

        public IConfiguration Configuration { get; }

        public  ElvantoTest()
        {
            var config = new ConfigurationBuilder()
                        .AddJsonFile("client-secrets.json")
                        .Build();

            _apikey = config["ElvantoApiKey"];

            this.ElvantoManager = new ElvantoManager(_apikey);
            RunBeforeTestFixture().Wait();
        }

        internal virtual Task RunBeforeTestFixture()
        {
            return Task.CompletedTask;
        }
    }
}
