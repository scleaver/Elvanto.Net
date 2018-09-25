using Elvanto.Net.Interfaces;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Elvanto.Net.Tests
{
    public abstract class ElvantoTest
    {
        protected IElvantoManager ElvantoManager;

        private string _apikey = "yourapikey";

        public IConfiguration Configuration { get; }

        public  ElvantoTest()
        {
            this.ElvantoManager = new ElvantoManager(_apikey);
            RunBeforeTestFixture().Wait();
        }

        internal virtual Task RunBeforeTestFixture()
        {
            return Task.CompletedTask;
        }
    }
}
