using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.Damages.PhysicalDamages
{
    public class Physical
    {
        public Crush  ?CrushDamage { get; set; }
        public Impact ?ImpactDamage { get; set; }
        public Pierce ?PierceDamage { get; set; }
        public Slice  ?SliceDamage { get; set; }
    }
}
