using Attributes.Damages.PhysicalDamages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Sword : Item
    {
        // Properties
        public string Name { get; set; }
        
        // Attributes
        public Physical PhysicalDamage { get; set; }
    }
}
