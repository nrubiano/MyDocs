using System.Net;
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
            
        }
    }
}
