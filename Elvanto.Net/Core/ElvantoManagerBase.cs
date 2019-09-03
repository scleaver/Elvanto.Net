using Microsoft.Extensions.Options;

namespace Elvanto.Net.Core
{
    public abstract class ElvantoManagerBase
    {
        protected readonly ElvantoOptions ElvantoOptions;

        public ElvantoManagerBase(string apiKey) => ElvantoOptions = new ElvantoOptions
        {
            ApiKey = apiKey,
        };

        protected ElvantoManagerBase(IOptions<ElvantoOptions> optionsAccessor) => ElvantoOptions = optionsAccessor.Value;

        protected ElvantoManagerBase()
        {
        }
    }
}
