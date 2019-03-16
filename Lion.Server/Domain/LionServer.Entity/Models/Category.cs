﻿using System;
using System.Collections.Generic;

namespace LionServer.Entity.Models
{
    public partial class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Disabled { get; set; }
        public int SortNo { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string TypeId { get; set; }
    }
}
