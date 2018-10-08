using Elvanto.Net.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Elvanto.Net.Core
{
    public class ElvantoException : Exception
    {
        public ElvantoException(ElvantoApiError apierror, HttpResponseMessage rawHttpResponseMessage = null) : base(formatMessage(apierror))
        {
            Detail = apierror.Error.ErrorMessage;
            Code = apierror.Error.ErrorCode;

            RawHttpResponseMessage = rawHttpResponseMessage;
        }

        private static string formatMessage(ElvantoApiError apierror)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Code: {apierror.Error.ErrorCode}");
            builder.AppendLine($"Detail: {apierror.Error.ErrorMessage}");
            return builder.ToString();
            throw new NotImplementedException();
        }

        public int Code { get; set; }
        public string Detail { get; set; }


        /// <summary>
        /// Gets or Sets the raw http response message.
        /// </summary>
        public HttpResponseMessage RawHttpResponseMessage { get; set; }

        public override IDictionary Data
        {
            get
            {
                var data = base.Data;
                data.Add("detail", Detail);
                data.Add("title", Code.ToString());
                data.Add("type", Code.ToString());
                data.Add("status", Code.ToString());
                data.Add("instance", null);
                data.Add("rawhttpresponsemessage", RawHttpResponseMessage);
                return data;
            }
        }
    }
}
