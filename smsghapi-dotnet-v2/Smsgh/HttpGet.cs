﻿namespace smsghapi_dotnet_v2.Smsgh
{
    /// <summary>
    ///     HTTP Get
    /// </summary>
    public class HttpGet : HttpRequest
    {
        /// <summary>
        ///     Constructs an HTTP GET request
        /// </summary>
        /// <param name="path">Partial URL</param>
        /// <param name="parameters">Name-value pairs to be appended to the URL</param>
        public HttpGet(string path, ParameterMap parameters) : base(path, parameters)
        {
            HttpMethod = "GET";
            ContentType = UrlEncoded;
        }
    }
}