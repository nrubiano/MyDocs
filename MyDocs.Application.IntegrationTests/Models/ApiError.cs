using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace MyDocs.Application.IntegrationTests.Models
{
    public class ApiError
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }
        
        [JsonProperty("status")]
        public HttpStatusCode Status { get; set; }
        
        [JsonProperty("errors")]
        public IDictionary<string, List<string>> Errors { get; set; }
    }
}
