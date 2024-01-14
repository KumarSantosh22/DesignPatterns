using DesignPattern.Builder;

namespace DesignPattern.ConsoleApp.Creational
{
    public class BuilderDriver
    {
        public void Drive()
        {
            HttpRequestMessage request = new HttpResquestBuilder()
                .SetUri(new Uri("https://jsonplaceholder.typicode.com/todos/1"))
                .SetMethod(HttpMethod.Get)
                .SetContent(new StringContent("application/json"))
                .SetHeader("Authorization", "None")
                .Build();
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.Send(request);
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        }
    }
}
