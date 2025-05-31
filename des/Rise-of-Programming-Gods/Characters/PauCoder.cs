using System;

namespace Rise_of_Programming_Gods.Characters
{
    /// <summary>
    /// PauCoder class represents a character who excels in writing elegant code.
    /// This character is inspired by Pauline Areola, who consistently writes clean,
    /// well-structured code and has a talent for finding elegant solutions to complex problems.
    /// 
    /// OOP Principles Demonstrated:
    /// 1. Inheritance: Inherits from the abstract Character class
    /// 2. Polymorphism: Implements its own version of the Attack() method
    /// 3. Encapsulation: Uses private fields and public properties
    /// 4. Abstraction: Builds upon the abstract Character class
    /// </summary>
    public class PauCoder : CodingWarrior
    {
        private readonly Random random = new Random();

        public PauCoder(string name) : base(name, 100)
        {
            // PauCoder start with 100 HP, representing their balanced approach
            // to problem-solving and code quality
        }

        /// <summary>
        /// Implements the Attack method with elegant code solutions
        /// </summary>
        /// <returns>Damage dealt by the attack</returns>
        public override int Attack()
        {
            int baseDamage = random.Next(8, 15);

            // 20% chance for critical hit (perfect code)
            if (random.Next(100) < 20)
            {
                baseDamage *= 2;
            }
            // 10% chance to miss (compilation error)
            else if (random.Next(100) < 10)
            {
                return 0;
            }

            return baseDamage;
        }
    }
}