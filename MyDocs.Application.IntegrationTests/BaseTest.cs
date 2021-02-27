using System;
using RestSharp;

namespace MyDocs.Application.IntegrationTests
{
    public class BaseTest : IDisposable
    {
        protected RestClient HttpClient;

        public void Setup()
        {
            HttpClient = new RestClient("https://localhost:5001/api");
        }
        

        public void Dispose()
        {
        }
    }
}
