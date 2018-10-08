using System;

namespace Elvanto.Net
{
    public class ElvantoOptions
    {
        public int PageSize { get; set; } = 1000;

        private string _authHeader;
        private string _apiKey;
        private string _oauthToken;

        public string AuthHeader => _authHeader;

        public string ApiKey
        {
            get { return _apiKey; }
            set
            {
                _apiKey = value;
                _oauthToken = null;
                _authHeader = $"Basic " + Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(string.Format("{0}:x", _apiKey)));
            }
        }

        public string OauthToken
        {
            get { return _oauthToken; }
            set
            {
                _oauthToken = value;
                _apiKey = null;
                _authHeader = $"OAuth {_oauthToken}";
            }
        }
    }
}