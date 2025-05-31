using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.Physicals.Constitutions
{
    public class Stamina : Attribute
    {
        public Stamina(int current, int max, int min = 0) : base(current, max, min)
        {
            // Specific Stamina initialization if any
        }


        public void Consume(int amount)
        {
            DecreseCurrent(amount);
        }

        public void Regenerate(int amount)
        {
            IncreaseCurrent(amount);
        }
    }
}
