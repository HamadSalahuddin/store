﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual List<Gadget> Gadgets { get; set; }

        public Category()
        {
            DateCreated = DateTime.Now;
        }
    }
}
