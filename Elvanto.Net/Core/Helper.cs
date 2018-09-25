using Elvanto.Net.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Elvanto.Net.Core
{
    public static class Helper
    {
        public static async Task EnsureSuccessElvantoAsync(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new ElvantoNotFoundException($"Unable to find the resource at {response.RequestMessage.RequestUri} ");
                }

                var responseContentStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                throw new ElvantoException(responseContentStream.Deserialize<ElvantoApiError>(), response);
            }
        }

        private static T Deserialize<T>(this Stream stream)
        {
            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var jsonSerializer = new JsonSerializer();
                return jsonSerializer.Deserialize<T>(jsonReader);
            }
        }
    }
}
