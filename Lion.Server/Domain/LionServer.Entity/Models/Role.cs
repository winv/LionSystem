using System;
using System.Collections.Generic;

namespace LionServer.Entity.Models
{
    public partial class Role
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateId { get; set; }
        public string TypeName { get; set; }
        public string TypeId { get; set; }
    }
}
