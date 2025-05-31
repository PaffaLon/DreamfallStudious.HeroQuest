using Attributes.Physicals.Constitutions;

namespace Attributes.Physicals.Constitutions
{
    public class Constitution
    {
        // Below is composistion applied.
        public Health? Health { get; private set; }
        public Stamina? Stamina { get; private set; }

        public Constitution(int healthCurrent, int healthMax, int healthMin,
                            int staminaCurrent, int staminaMax, int staminaMin)
        {
            Health = new Health(healthCurrent, healthMax, healthMin);
            Stamina = new Stamina(staminaCurrent, staminaMax, staminaMin);
        }

    }
}
