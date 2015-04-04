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
            client.BaseUrl = new Uri("http://localhost:4540");
            var request = new RestRequest("calcDistance?ax={ax}&ay={ay}&bx={bx}&by={by}", Method.POST);
            
            request.AddParameter("ax", 4, ParameterType.UrlSegment);
            request.AddParameter("ay", 5, ParameterType.UrlSegment);
            request.AddParameter("bx", 2, ParameterType.UrlSegment);
            request.AddParameter("bx", 3, ParameterType.UrlSegment);

            RestResponse response = (RestResponse)client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);

        }
    }
}
