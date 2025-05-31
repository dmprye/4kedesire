Programming Gods Battle Simulator
================================

A C# Windows Forms application that simulates turn-based battles between programming-themed characters.

Features
--------
- Seven unique character types: CodeWizard, DebugWarrior, JeanGrey, MuadDib, ScarletWitch, SpiderMan, and StarLord
- Real-time battle log with detailed combat information
- Health tracking for both players
- Turn-based combat system
- Exception handling for user input and battle logic

Character Types
--------------
1. CodeWizard
   - Specializes in writing elegant code
   - Has a chance to deal critical hits (double damage)
   - Can occasionally miss attacks
   - Base health: 100

2. DebugWarrior
   - Excels at finding and fixing bugs
   - Deals consistent damage
   - Has a chance to chain attacks for bonus damage
   - Base health: 120

3. JeanGrey
- Specializes in powerful psychic and mental attacks
- Has a chance to enter Phoenix Mode for a massive boost
- Psychic power builds up over time
- Base health: 90

4. MuadDib
- Relies on strategy and foresight in battle
- Can execute perfectly timed moves for greater impact
- Prescience steadily increases with each turn
- Base health: 105

5. ScarletWitch
- Thrives on creativity and unconventional tactics
- May distort reality for unpredictable effects
- Harnesses chaos energy as the fight progresses
- Base health: 85

6. SpiderMan
- Known for quick reflexes and fast decision-making
- Has a chance to ensnare enemies using a Web Attack
- Can chain combos for sustained pressure
- Base health: 95

7. StarLord
- Excels in planning and team-based strategies
- May activate Tactical Advantage to outsmart enemies
- Can gain High Ground for extra offensive bonuses
- Base health: 110

Object-Oriented Programming Principles
------------------------------------
1. Encapsulation
   - Private fields with public properties in Character class
   - Protected setters for character properties
   - BattleManager encapsulates battle logic and state

2. Inheritance
   - Abstract Character base class
   - CodeWizard and DebugWarrior inherit from Character
   - Common properties and methods defined in base class

3. Polymorphism
   - Abstract Attack() method in Character class
   - Each character type implements its own attack logic
   - Virtual TakeDamage() method for potential overrides

4. Abstraction
   - Character class is abstract
   - BattleManager provides a clean interface for battle operations
   - Form handles UI without knowing battle implementation details

5. Exception Handling
   - Input validation for player names
   - Battle state validation
   - User-friendly error messages
   - Graceful error recovery

Challenges Faced
---------------
1. Designing a balanced combat system that's both fun and fair
2. Implementing real-time battle updates without blocking the UI
3. Creating distinct character types with unique abilities
4. Managing battle state and turn order
5. Providing clear feedback to users during battles

How to Use
----------
1. Enter names for both players
2. Select character types from the dropdown menus
3. Click "Start Battle" to begin
4. Watch the battle unfold in the battle log
5. The winner will be announced when the battle ends

Note: This project was created as a demonstration of OOP principles in C# and is meant to be both educational and entertaining. 