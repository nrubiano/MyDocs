using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using MyDocs.Hosts.Backend;

namespace MyDocs.Application.IntegrationTests
{
    public class BaseTest : IDisposable
    {
        protected TestServer _testServer;

        public void Setup()
        {
            var webBuilder = new WebHostBuilder();

            webBuilder.UseStartup<Startup>();

            _testServer = new TestServer(webBuilder);
        }

        public async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request)
        {
            using var scope = _testServer.Services.CreateScope();

            var mediator = scope.ServiceProvider.GetService<IMediator>();

            return await mediator.Send(request);
        }

        public void Dispose()
        {
        }
    }
}
