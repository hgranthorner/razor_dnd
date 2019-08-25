using System;
using System.Security.Cryptography;

namespace dnd.BusinessLogic
{
    public static class DiceRoller
    {
        public static int RollD20(int modifier = 0)
        {
            var rng = new Random();
            return Convert.ToInt32(Math.Ceiling(rng.NextDouble() * 20));
        }
    }
}