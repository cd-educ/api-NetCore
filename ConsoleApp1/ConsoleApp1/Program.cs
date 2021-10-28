using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new RestClient("https://localhost:44373");
            var request = new RestRequest("/api/check", Method.POST);
            request.AddJsonBody(new { user="admin", pwd="admin"});

            var response = client.Execute(request);

            var obj = JObject.Parse(response.Content);

            Console.WriteLine(obj["valid"]);
        }
    }
}
