using Attributes;

namespace Characters
{
    public abstract class Character
    {
        protected Character(Guid id, string name, int healthCurrent, int healthMax, int healthMin, int staminaCurrent, int staminaMax, int staminaMin)
        {
            ID = id;
            ApplyDefaultData(name, healthCurrent, healthMax, healthMin, staminaCurrent, staminaMax, staminaMin);
        }

        protected Character(string name, int healthCurrent, int healthMax, int healthMin, int staminaCurrent, int staminaMax, int staminaMin)
        {
            ID = Guid.NewGuid();
            ApplyDefaultData(name, healthCurrent, healthMax, healthMin, staminaCurrent, staminaMax, staminaMin);
        }

        private void ApplyDefaultData(string name, int healthCurrent, int healthMax, int healthMin, int staminaCurrent, int staminaMax, int staminaMin)
        {
            Name = name;
            Strength = new Strength(healthCurrent, healthMax, healthMin,
                                    staminaCurrent, staminaMax, staminaMin);
        }

        public Guid ID { get; private set; }
        /// <summary>
        /// Represents a characters name.
        /// </summary>
        public virtual string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                         "Error Code: C0" +
                        $"Requierment: {nameof(Name)}: Can't be empty or white space." +
                         "Description: Invalid character name provided." +
                        $"Source: {nameof(value)}"
                        );
                }
                else
                    _name = value;
            }
        }

        // Attributes
        public Strength? Strength { get; private set; }

        // EqipmentSlots - Specefics the amount of slots a character can have, for an eqipment type.
        public abstract int SlotHead { get; }
        public abstract int SlotChest { get; }
        public abstract int SlotHands { get; }
        public abstract int SlotLegs { get; }
        public abstract int SlotFeets { get; }
        public abstract int Rings { get; }


        // Fields
        private string? _name;
    }
}
