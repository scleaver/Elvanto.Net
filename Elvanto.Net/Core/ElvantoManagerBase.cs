namespace Elvanto.Net.Core
{
    public abstract class ElvantoManagerBase
    {
        protected readonly ElvantoOptions ElvantoOptions;

        public ElvantoManagerBase(string apiKey) => ElvantoOptions = new ElvantoOptions
        {
            ApiKey = apiKey,
        };

#if NET_CORE

        protected ElvantoManagerBase(IOptions<ElvantoOptions> optionsAccessor) => ElvantoOptions = optionsAccessor.Value;

#else
        protected ElvantoManagerBase(ElvantoOptions options) => ElvantoOptions = options;
#endif

        protected ElvantoManagerBase()
        {
        }
    }
}
