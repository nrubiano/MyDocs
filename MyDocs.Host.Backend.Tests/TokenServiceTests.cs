using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using AutoMapper.Mappers;
using Microsoft.Extensions.Configuration;
using MyDocs.Hosts.Backend.Services;
using Xunit;
using Moq;

namespace MyDocs.Host.Backend.Tests
{
    public class TokenServiceTests
    {
        private readonly IConfiguration _configuration;

        public TokenServiceTests()
        {
            _configuration = Mock.Of<IConfiguration>();
        }

        private void MockConfig()
        {
            Mock.Get(_configuration)
                .Setup(x => x["TokenKey"])
                .Returns("47674218502118626857");

            Mock.Get(_configuration)
                .Setup(x => x["TokenIssuer"])
                .Returns("issuer");

            Mock.Get(_configuration)
                .Setup(x => x["TokenAudience"])
                .Returns("key");
        }

        [Fact]
        public void Should_Throw_Exception_Without_Claims()
        {
            var tokenService = new TokenService(_configuration);

            var exception = Assert.Throws<ArgumentNullException>(() => tokenService.GenerateToken(null));
            
            Assert.Equal("claims", exception.ParamName);
            Assert.Equal("The claims are needed to issue the token. (Parameter 'claims')", exception.Message);
        }

        [Fact]
        public void Should_Throw_Exception_Without_TokenIssuer()
        {
            Mock.Get(_configuration)
                .Setup(x => x["TokenKey"])
                .Returns("key");

            var tokenService = new TokenService(_configuration);

            var exception = Assert.Throws<ArgumentNullException>(() => tokenService.GenerateToken(new Dictionary<string, object>()));

            Assert.Equal("tokenIssuer", exception.ParamName);
            Assert.Equal("The TokenIssuer is needed to issue the token. (Parameter 'tokenIssuer')", exception.Message);
        }

        [Fact]
        public void Should_Throw_Exception_Without_TokenAudience()
        {
            Mock.Get(_configuration)
                .Setup(x => x["TokenKey"])
                .Returns("key");

            Mock.Get(_configuration)
                .Setup(x => x["TokenIssuer"])
                .Returns("issuer");

            var tokenService = new TokenService(_configuration);

            var exception = Assert.Throws<ArgumentNullException>(() => tokenService.GenerateToken(new Dictionary<string, object>()));

            Assert.Equal("tokenAudience", exception.ParamName);
            Assert.Equal("The TokenAudience is needed to issue the token. (Parameter 'tokenAudience')", exception.Message);
        }

        [Fact]
        public void Should_Generate_Token_With_RoleId()
        {
            MockConfig();

            var tokenService = new TokenService(_configuration);

            var token = tokenService.GenerateToken(new Dictionary<string, object>
            {
                {"RoleId", 1}
            });

            var handler = new JwtSecurityTokenHandler();
            var securityToken = handler.ReadToken(token.AccessToken);
            var jwtSecurityToken = handler.ReadToken(token.AccessToken) as JwtSecurityToken;

            Assert.NotNull(token);
            Assert.NotNull(token.AccessToken);
            Assert.Equal("issuer", securityToken.Issuer);

            var hasRoleId = jwtSecurityToken.Claims.Any(x => x.Type.Equals("RoleId"));

            Assert.True(hasRoleId);
        }
    }
}
