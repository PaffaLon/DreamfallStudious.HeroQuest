
namespace Attributes.Physicals.Constitutions
{
    public class Health : Attribute
    {
        public Health(int current, int max, int min) : base(current, max, min)
        {
            // Health-specific initialization if any.
        }


        public void ApplyHealing(int val)
        {
            IncreaseCurrent(val);
        }

        public void ApplyDamage(int val)
        {
            DecreseCurrent(val);
        }
    }
}
