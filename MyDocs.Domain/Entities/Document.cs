using System;

namespace MyDocs.Domain.Entities
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string StoragePath { get; set; }
        public int OwnerId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
