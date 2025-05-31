using System;

namespace Rise_of_Programming_Gods.Characters
{
    /// <summary>
    /// RyenVizier class represents a character with exceptional foresight and strategic thinking.
    /// This character is inspired by Ryen Nava, who demonstrates the ability to anticipate
    /// problems and plan solutions before they occur in programming projects.
    /// 
    /// Design Choices:
    /// 1. Health (105): Above average
    ///    - Represents ability to handle complex situations
    ///    - Matches their strategic approach
    /// 
    /// 2. Base Damage (11-21): Strategic attacks
    ///    - Reflects their methodical problem-solving
    ///    - Higher base damage due to preparation
    /// 
    /// 3. Prescience Accumulation:
    ///    - Builds up over time
    ///    - Represents growing understanding
    /// 
    /// 4. Perfect Timing (20% chance):
    ///    - Represents optimal solution timing
    ///    - Matches their ability to choose the right moment
    /// 
    /// OOP Principles Demonstrated:
    /// 1. Inheritance:
    ///    - Inherits from abstract Character class
    ///    - Gets base functionality (health, name, damage handling)
    ///    - Extends with strategic-specific traits
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
    public class RyenVizier : CodingWarrior
    {
        private readonly Random random = new Random();
        private int prescienceStacks = 0;

        public RyenVizier(string name) : base(name, 100)
        {
            // RyenVizier has balanced health, representing their adaptability
        }

        public override int Attack()
        {
            int baseDamage = random.Next(11, 21);

            // Accumulate prescience
            prescienceStacks = Math.Min(prescienceStacks + 1, 3);
            baseDamage += prescienceStacks;

            // 20% chance for perfect timing (critical hit)
            if (random.Next(100) < 20)
            {
                baseDamage *= 2;
                prescienceStacks = 0; // Reset on perfect timing
            }

            return baseDamage;
        }
    }
}