using System;

namespace Rise_of_Programming_Gods.Characters
{
    /// <summary>
    /// Abstract base class representing a character in the RPG battle simulator.
    /// This class serves as the foundation for all character types in the game.
    /// 
    /// OOP Principles Demonstrated:
    /// 1. Abstraction:
    ///    - Abstract class that defines the common interface for all characters
    ///    - Hides implementation details while exposing necessary functionality
    /// 
    /// 2. Encapsulation:
    ///    - Private fields (name, health, maxHealth) with controlled access
    ///    - Public properties with protected setters
    ///    - Validation in property setters to ensure data integrity
    ///    - Methods that operate on the encapsulated data
    /// 
    /// 3. Inheritance:
    ///    - Base class for all character types
    ///    - Provides common functionality and properties
    ///    - Allows derived classes to extend and specialize behavior
    /// 
    /// 4. Polymorphism:
    ///    - Common interface for different character implementations
    ///    - Virtual TakeDamage() method that can be overridden if needed
    /// </summary>
    public abstract class CodingWarrior
    {
        // Encapsulation: Private fields with public properties
        private string name;
        private int health;
        private int maxHealth;

        // Properties with encapsulation
        public string Name
        {
            get => name;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                name = value;
            }
        }

        public int Health
        {
            get => health;
            protected set
            {
                // Manual clamping for .NET Framework 4.7.2 compatibility
                if (value < 0)
                    health = 0;
                else if (value > MaxHealth)
                    health = MaxHealth;
                else
                    health = value;
            }
        }

        public int MaxHealth
        {
            get => maxHealth;
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Max health must be greater than 0.");
                maxHealth = value;
            }
        }

        /// <summary>
        /// Constructor for initializing a CodingWarrior
        /// </summary>
        /// <param name="name">Character name</param>
        /// <param name="maxHealth">Maximum health points</param>
        protected CodingWarrior(string name, int maxHealth)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;  // Start with full health
        }

        /// <summary>
        /// Reduces the character's health by specified damage amount
        /// </summary>
        /// <param name="damage">Amount of damage to take</param>
        /// <exception cref="ArgumentException">Thrown when damage is negative</exception>
        public virtual void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentException("Damage cannot be negative.");

            Health -= damage;
        }

        /// <summary>
        /// Checks if the character is still alive
        /// </summary>
        /// <returns>True if health is greater than 0</returns>
        public bool IsAlive() => Health > 0;

        /// <summary>
        /// Abstract method that defines how the character attacks
        /// </summary>
        /// <returns>Amount of damage dealt</returns>
        public abstract int Attack();
    }
}