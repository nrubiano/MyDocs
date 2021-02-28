using System;

namespace MyDocs.Hosts.Backend.Models
{
    public class TokenModel
    {
        public string AccessToken;
        public DateTime ExpiresIn;
        public string TokenType = "Bearer";
    }
}
