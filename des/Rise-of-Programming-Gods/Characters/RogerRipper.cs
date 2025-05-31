using System;

namespace Rise_of_Programming_Gods.Characters
{
    /// <summary>
    /// RogerRipper class represents a character who excels in finding and fixing bugs.
    /// This character is inspired by Roger Macaraeg, who has an exceptional ability
    /// to track down and resolve complex bugs, often finding solutions that others miss.
    /// 
    /// Design Choices:
    /// 1. Health (120): Higher than average to reflect resilience
    ///    - Represents ability to handle long debugging sessions
    ///    - Matches their persistence in solving complex problems
    /// 
    /// 2. Base Damage (15-20): Consistent and reliable
    ///    - Reflects their methodical approach to debugging
    ///    - Slightly higher than average due to expertise
    /// 
    /// 3. Chain Attack (30% chance):
    ///    - Represents finding related bugs
    ///    - Matches their ability to spot patterns
    /// 
    /// 4. Expertise Bonus:
    ///    - Accumulates with successful chain attacks
    ///    - Reflects growing understanding of the codebase
    /// 
    /// OOP Principles Demonstrated:
    /// 1. Inheritance:
    ///    - Inherits from abstract Character class
    ///    - Gets base functionality (health, name, damage handling)
    ///    - Extends with debugging-specific traits
    /// 
    /// 2. Encapsulation:
    ///    - Private fields for internal state
    ///    - Public properties with controlled access
    ///    - Protected setters for health and name
    /// 
    /// 3. Abstraction:
    ///    - Builds upon abstract Character class
    ///    - Hides implementation details
    ///    - Exposes only necessary functionality
    /// 
    /// 4. Polymorphism:
    ///    - Character type can be used where Character is expected
    ///    - Damage calculation handled by BattleManager
    ///    - Maintains unique characteristics while fitting the battle system
    /// </summary>
    public class RogerRipper : CodingWarrior
    {
        private readonly Random random = new Random();
        private int debugStreak = 0;

        public RogerRipper(string name) : base(name, 100)
        {
            // RogerRipper start with 120 HP, representing their resilience
            // and ability to handle complex debugging sessions
        }

        public override int Attack()
        {
            int baseDamage = random.Next(15, 20);

            // 30% chance for chain attack (finding related bugs)
            if (random.Next(100) < 30)
            {
                baseDamage += 10;
                debugStreak++;
            }

            // Expertise bonus from consecutive debug finds
            if (debugStreak > 0)
            {
                baseDamage += debugStreak * 2;
            }

            return baseDamage;
        }
    }
}