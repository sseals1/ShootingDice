using System;
using System.Linq;

namespace ShootingDice
{

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLooserUpperHalfPlayer : SoreLooserPlayer
    {
        public int Roll()
        {
            Console.WriteLine($"Options: {String.Join(", ", Enumerable.Range(DiceSize / 2 + 1, DiceSize / 2))}");
            return new Random().Next(DiceSize / 2, DiceSize) + 1;
            public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                throw new Exception("You're acting like sore looser!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}
}