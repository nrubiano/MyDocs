using System;
using System.Net;
using MyDocs.Application.Common.Dtos;
using MyDocs.Application.IntegrationTests.Models;
using MyDocs.Application.IntegrationTests.Extensions;
using RestSharp;
using Xunit;

namespace MyDocs.Application.IntegrationTests
{
    public class GroupCommandsTests : BaseTest
    {
        public GroupCommandsTests()
        {
            Setup();
        }

        [Fact]
        public void Should_Require_Group_Name()
        {
            var request = new RestRequest("groups", DataFormat.Json)
                .AddJsonBody(new { Name = "" });

            var response = HttpClient.Post(request);
            var responseModel = response.ReadJsonResponse<ApiError>();
            
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);   
            Assert.Contains(responseModel.Errors,
                item => item.Key.Equals("Name") && item.Value.Contains("'Name' must not be empty."));
        }

        [Fact]
        public void Should_Create_New_Group()
        {
            var model = new GroupDto
            {
                Name = $"My Group {Guid.NewGuid()}"
            };

            var request = new RestRequest("groups", DataFormat.Json)
                .AddJsonBody(model);
            
            var response = HttpClient.Post(request);

            if (!response.IsSuccessful)
            {
                throw new Exception("The request was not a success.");
            }

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }
    }
}
