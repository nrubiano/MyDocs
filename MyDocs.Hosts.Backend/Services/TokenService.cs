using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyDocs.Hosts.Backend.Models;

namespace MyDocs.Hosts.Backend.Services
{
    public class TokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public TokenModel GenerateToken(IDictionary<string, object> claims)
        {
            if (claims == null)
            {
                throw new ArgumentNullException(nameof(claims), "The claims are needed to issue the token.");
            }

            var tokenKey = _configuration["TokenKey"];
            var tokenIssuer = _configuration["TokenIssuer"];
            var tokenAudience = _configuration["TokenAudience"];

            if (tokenKey == null)
            {
                throw new ArgumentNullException(nameof(tokenKey), "The TokenKey is needed to issue the token.");
            }

            if (tokenIssuer == null)
            {
                throw new ArgumentNullException(nameof(tokenIssuer), "The TokenIssuer is needed to issue the token.");
            }

            if (tokenAudience == null)
            {
                throw new ArgumentNullException(nameof(tokenAudience), "The TokenAudience is needed to issue the token.");
            }

            var userClaims = new List<Claim>();

            userClaims.AddRange(claims.Select(c => new Claim(c.Key, c.Value.ToString() ?? string.Empty)));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var bearerTokenExpirationDate = DateTime.UtcNow.AddMinutes(15);

            var token = new JwtSecurityToken(
                tokenIssuer,
                tokenAudience,
                userClaims,
                expires: bearerTokenExpirationDate,
                signingCredentials: credentials);

            var accessToken = new JwtSecurityTokenHandler().WriteToken(token);

            return new TokenModel
            {
                AccessToken = accessToken,
                ExpiresIn = bearerTokenExpirationDate
            };
        }
    }
}
