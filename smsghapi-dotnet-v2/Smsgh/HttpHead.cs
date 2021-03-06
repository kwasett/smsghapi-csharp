﻿namespace smsghapi_dotnet_v2.Smsgh
{
    /// <summary>
    ///     HTTP Head
    /// </summary>
    public class HttpHead : HttpRequest
    {
        /// <summary>
        ///     Constructs an HTTP HEAD request
        /// </summary>
        /// <param name="path">Partial URL</param>
        /// <param name="parameters">Name-value pairs to be appended to the URL</param>
        public HttpHead(string path, ParameterMap parameters) : base(path, parameters)
        {
            HttpMethod = "HEAD";
            ContentType = UrlEncoded;
        }
    }
}