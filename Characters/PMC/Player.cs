using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.PMC
{
    public class Player : Character
    {
        public Player(string name, int healthCurrent, int healthMax, int healthMin,
                                   int staminaCurrent, int staminaMax, int staminaMin)
            : base(name, healthCurrent, healthMax, healthMin, staminaCurrent, staminaMax, staminaMin) // Calls base Character constructor
        {
            // Any Player-specific initialization
        }

        public override int SlotHead { get; } = 1;
        public override int SlotChest { get; } = 1;
        public override int SlotHands { get; } = 1;
        public override int SlotLegs { get; } = 1;
        public override int SlotFeets { get; } = 1;
        public override int Rings { get; } = 2;
    }
}
