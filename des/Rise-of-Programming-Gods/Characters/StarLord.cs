using System;

namespace Rise_of_Programming_Gods.Characters
{
    /// <summary>
    /// StarLord class represents a character who excels in strategic planning and team coordination.
    /// This character is inspired by John Doe, who demonstrates exceptional leadership
    /// and tactical thinking in group projects and team activities.
    /// 
    /// Design Choices:
    /// 1. Health (110): Slightly above average
    ///    - Represents adaptability and resilience
    ///    - Matches their ability to handle various situations
    /// 
    /// 2. Base Damage (12-22): Variable but reliable
    ///    - Reflects their strategic approach
    ///    - Wider range shows adaptability
    /// 
    /// 3. Tactical Advantage (25% chance):
    ///    - Represents strategic positioning
    ///    - Matches their ability to find optimal solutions
    /// 
    /// 4. High Ground Bonus (30% chance):
    ///    - Represents superior positioning
    ///    - Reflects their ability to gain advantage
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
    public class StarLord : CodingWarrior
    {
        private readonly Random random = new Random();

        public StarLord(string name) : base(name, 100)
        {
            // StarLord has balanced health, representing their adaptability
        }

        public override int Attack()
        {
            int baseDamage = random.Next(12, 22);

            // 25% chance for tactical advantage
            if (random.Next(100) < 25)
            {
                baseDamage += 15;
            }
            // 30% chance for high ground bonus (doesn't stack with tactical advantage)
            else if (random.Next(100) < 30)
            {
                baseDamage += 10;
            }

            return baseDamage;
        }
    }
}