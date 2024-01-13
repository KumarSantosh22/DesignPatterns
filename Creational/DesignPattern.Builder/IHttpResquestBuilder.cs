namespace DesignPattern.Builder
{
    public interface IHttpResquestBuilder
    {
        IHttpResquestBuilder SetMethod(HttpMethod method);
        IHttpResquestBuilder SetUri(Uri uri);
        IHttpResquestBuilder SetContent(HttpContent content);
        IHttpResquestBuilder SetHeader(string name, string value);
        HttpRequestMessage Build();
    }
}
