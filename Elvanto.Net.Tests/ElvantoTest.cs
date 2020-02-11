using Elvanto.Net.Interfaces;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Elvanto.Net.Tests
{
    public abstract class ElvantoTest
    {
        protected IElvantoManager ElvantoManager;

        IConfiguration Configuration { get; set; }

        public  ElvantoTest()
        {

            // the type specified here is just so the secrets library can 
            // find the UserSecretId we added in the csproj file
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<ElvantoTest>();

            Configuration = builder.Build();

            var _apikey = Configuration["ElvantoApiKey"];

            this.ElvantoManager = new ElvantoManager(_apikey);
            RunBeforeTestFixture().Wait();
        }

        internal virtual Task RunBeforeTestFixture()
        {
            return Task.CompletedTask;
        }
    }
}
