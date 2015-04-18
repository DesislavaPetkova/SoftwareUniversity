using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTConsumer
{
    using RestSharp;

    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://localhost:4540/api/");
            var request = new RestRequest("calcDistance?ax={ax}&ay={ay}&bx={bx}&by={by}", Method.POST);
            
            request.AddUrlSegment("ax", "4");
            request.AddUrlSegment("ay", "5");
            request.AddUrlSegment("bx", "2");
            request.AddUrlSegment("bx", "3");

            RestResponse response = (RestResponse)client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);

        }
    }
}
