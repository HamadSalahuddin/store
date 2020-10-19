using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Store.Model
{
    public class Gadget
    {
        public int GadgetId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
