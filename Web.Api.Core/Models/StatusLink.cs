using System.Collections.Generic;

namespace Web.Api.Core.Models
{
    public class StatusLink
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        public ICollection<Status> StatusesFrom { get; set; }
        public ICollection<Status> StatusesTo { get; set; }
    }
}