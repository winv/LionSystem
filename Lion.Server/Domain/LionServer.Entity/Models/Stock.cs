using System;
using System.Collections.Generic;

namespace LionServer.Entity.Models
{
    public partial class Stock
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public int Status { get; set; }
        public string Viewable { get; set; }
        public string User { get; set; }
        public DateTime Time { get; set; }
        public string OrgId { get; set; }
    }
}
