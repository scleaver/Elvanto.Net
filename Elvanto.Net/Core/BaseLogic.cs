using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Elvanto.Net.Core
{
    public abstract class BaseLogic
    {
        internal int _pageSize => _options.PageSize;

        internal ElvantoOptions _options;

        protected BaseLogic(ElvantoOptions options)
        {
            _options = options;
        }

        protected HttpClient CreateElvantoClient(string resource)
        {
            var handler = new HttpClientHandler();
            if (handler.SupportsAutomaticDecompression)
            {
                handler.AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate;
            }

            var client = new HttpClient(handler)
            {
                BaseAddress = new Uri(string.Concat("https://api.elvanto.com/v1/", resource, ".json"))
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", _options.AuthHeader);
            return client;
        }
    }
}
