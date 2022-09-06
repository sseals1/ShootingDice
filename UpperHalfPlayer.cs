using System;
using System.Linq;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine($"Options: {String.Join(", ", Enumerable.Range(DiceSize / 2 + 1, DiceSize / 2))}");
            return new Random().Next(DiceSize / 2, DiceSize) + 1;

        }
    }
}