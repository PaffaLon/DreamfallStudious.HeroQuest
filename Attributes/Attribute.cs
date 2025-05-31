
namespace Attributes
{
    public abstract class Attribute
    {
        public int Current { get; protected set; }
        public int Max { get; protected set; }
        public int Min { get; protected set; }

        private int _current;
        private int _max;
        private int _min;
        protected Attribute(int current, int max, int min)
        {
            // Max should never be less than Min
            if (max < min)
                throw new ArgumentOutOfRangeException(nameof(max), $"Max ({max}) cannot be less than Min ({min}).");


            // Current must be within bounds
            if (current < min || current > max)
            {
                throw new ArgumentOutOfRangeException(nameof(current), $"Current ({current}) must be between Min ({min}) and Max ({max}).");
            }

            _current = current;
            _max = max;
            _min = min;
        }

        protected void IncreaseCurrent(int x) { Current = Math.Min(Current + x, Max); }// Don't exceed Max 
        protected void DecreseCurrent(int x)
        {
            Current = Math.Max(Current - x, Min); // Don't go below Min



            // Methods to adjust Max/Min if necessary, adjusting Current if it falls out of bounds
            void SetMax(int newMax)
            {
                if (newMax < Min)
                {
                    throw new ArgumentOutOfRangeException(nameof(newMax), $"New Max ({newMax}) cannot be less than current Min ({Min}).");
                }
                Max = newMax;
                if (Current > Max) Current = Max; // Adjust Current if it now exceeds new Max
            }

            void SetMin(int newMin)
            {
                if (newMin > Max)
                {
                    throw new ArgumentOutOfRangeException(nameof(newMin), $"New Min ({newMin}) cannot be greater than current Max ({Max}).");
                }
                Min = newMin;
                if (Current < Min) Current = Min; // Adjust Current if it now falls below new Min
            }
        }
    }
}
