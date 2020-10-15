using System;

namespace Oracle.Web.Data.Entities
{
    public class Bird
    {
        public Guid Id { get; set; }
        public string BirdName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
