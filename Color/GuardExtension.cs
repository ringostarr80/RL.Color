using System;

namespace RL
{
    public static class GuardExtension
    {
        public static void RangeCheck(this double value, double min, double max, string name)
        {
            if (value < min || value > max)
            {
                throw new ArgumentOutOfRangeException(name, value, $"Value must be between {min} and {max}");
            }
        }
    }
}
