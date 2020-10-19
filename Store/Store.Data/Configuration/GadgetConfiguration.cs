using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class GadgetConfiguration: EntityTypeConfiguration<Gadget>
    {
        public GadgetConfiguration()
        {
            ToTable("Gadgets");
            Property(gadget => gadget.Name).IsRequired().HasMaxLength(50);
            Property(gadget => gadget.Price).IsRequired().HasPrecision(8, 2);
            Property(gadget => gadget.CategoryId).IsRequired();
        }
    }
}
