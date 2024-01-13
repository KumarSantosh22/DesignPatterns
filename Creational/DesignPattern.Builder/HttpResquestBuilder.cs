
namespace DesignPattern.Builder
{
    public class HttpResquestBuilder : IHttpResquestBuilder
    {
        private HttpMethod? _method = null;
        private Uri? _uri = null;
        private HttpContent? _content = null;
        private Dictionary<string, string> _headers = new();

        public IHttpResquestBuilder SetUri(Uri uri)
        {
            _uri = uri;
            return this;
        }

        public IHttpResquestBuilder SetContent(HttpContent content)
        {
            _content = content;
            return this;
        }

        public IHttpResquestBuilder SetHeader(string name, string value)
        {
            _headers[name] = value;
            return this;
        }

        public IHttpResquestBuilder SetMethod(HttpMethod method)
        {
            _method = method;
            return this;
        }

        public HttpRequestMessage Build()
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(_method, _uri)
            {
                Content = _content
            };
            foreach(KeyValuePair<string, string> header in _headers.ToList())
            {
                httpRequestMessage.Headers.Add(header.Key, header.Value);

            }
            return httpRequestMessage;
        }
    }
}
