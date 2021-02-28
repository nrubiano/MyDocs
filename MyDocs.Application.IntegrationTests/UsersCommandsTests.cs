using System.Net;
using MyDocs.Application.IntegrationTests.Models;
using MyDocs.Application.IntegrationTests.Extensions;
using RestSharp;
using Xunit;

namespace MyDocs.Application.IntegrationTests
{
    public class UserCommandsTests : BaseTest
    {
        public UserCommandsTests()
        {
            Setup();
        }

        [Fact]
        public void Should_Authenticate_User_By_UserName()
        {
            var request = new RestRequest("auth/token", DataFormat.Json)
                .AddJsonBody(new { UserName = "", Password = "" });

            var response = HttpClient.Post(request);
            var responseModel = response.ReadJsonResponse<ApiError>();
            
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);   
            Assert.Contains(responseModel.Errors,
                item => item.Key.Equals("Name") && item.Value.Contains("'Name' must not be empty."));
        }
    }
}
