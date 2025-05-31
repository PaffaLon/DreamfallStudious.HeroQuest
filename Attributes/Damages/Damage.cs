using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.Damages
{
    /// <summary>
    /// Commonly shared attributes among various damage types.
    /// </summary>
    public abstract class Damage
    {
        /// <summary>
        /// Represents the amount of damage the object or entity does.
        /// </summary>
        public int Amount { get; }

        /// <summary>
        /// The Maximum amount of damage.
        /// </summary>
        public int AmountMax { get; }
        
        /// <summary>
        /// The minimum amount of damage.
        /// </summary>
        public int AmountMin { get; }

        
        public bool IgnoresArmour { get; }
    }
}
