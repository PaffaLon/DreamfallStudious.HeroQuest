using Attributes.Physicals.Constitutions;

namespace Attributes
{
    public class Strength
    {
        public Constitution Constitution { get; private set; }

        public Strength(int healthCurrent, int healthMax, int healthMin,
                            int staminaCurrent, int staminaMax, int staminaMin)
        {
            Constitution = new(healthCurrent, healthMax, healthMin,
                                staminaCurrent, staminaMax, staminaMin);
        }

    }
}
