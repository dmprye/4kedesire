using System;
using System.Collections.Generic;
using Rise_of_Programming_Gods.Characters;

namespace Rise_of_Programming_Gods
{
    public class BattleManager
    {
        private CodingWarrior player1;
        private CodingWarrior player2;
        private readonly List<string> battleLog = new List<string>();
        private bool isBattleInProgress = false;
        private readonly Random random = new Random();

        // Add these public properties
        public CodingWarrior Player1 => player1;
        public CodingWarrior Player2 => player2;
        public IReadOnlyList<string> BattleLog => battleLog.AsReadOnly();
        public bool IsBattleInProgress => isBattleInProgress;
        public CodingWarrior CurrentLeader =>
            player1?.Health > player2?.Health ? player1 : player2;

        public void InitializeBattle(CodingWarrior p1, CodingWarrior p2)
        {
            if (p1 == null || p2 == null)
                throw new ArgumentNullException("Both players must be initialized.");

            player1 = p1;
            player2 = p2;
            battleLog.Clear();
            isBattleInProgress = true;

            LogBattleStart();
        }

        public bool ExecuteTurn()
        {
            ValidateBattleState();

            var (first, second) = GetAttackOrder();
            bool battleContinues = ProcessAttacks(first, second);

            if (!battleContinues) return false;

            (first, second) = (second, first); // Switch turns
            return ProcessAttacks(first, second);
        }

        private (CodingWarrior first, CodingWarrior second) GetAttackOrder()
        {
            return random.Next(2) == 0
                ? (player1, player2)
                : (player2, player1);
        }

        private bool ProcessAttacks(CodingWarrior attacker, CodingWarrior defender)
        {
            int damage = attacker.Attack();
            defender.TakeDamage(damage);

            LogAttack(attacker, defender, damage);

            if (!defender.IsAlive())
            {
                EndBattle(attacker);
                return false;
            }
            return true;
        }

        private void ValidateBattleState()
        {
            if (!isBattleInProgress)
                throw new InvalidOperationException("No battle is in progress.");
        }

        private void LogBattleStart()
        {
            AddToLog($"Battle started between {player1.Name} ({player1.GetType().Name}) " +
                    $"and {player2.Name} ({player2.GetType().Name})!");
        }

        private void LogAttack(CodingWarrior attacker, CodingWarrior defender, int damage)
        {
            string attackDesc = "";

            if (attacker is PauCoder)
                attackDesc = $"{attacker.Name} strikes!";
            else if (attacker is RogerRipper)
                attackDesc = $"{attacker.Name} slashes!";
            else if (attacker is RyenVizier)
                attackDesc = $"{attacker.Name} casts!";
            else if (attacker is StarLord)
                attackDesc = $"{attacker.Name} attacks!";
            else
                attackDesc = $"{attacker.Name} hits!";


            AddToLog($"{attackDesc} -> {defender.Name} takes {damage} damage! " +
                    $"(Remaining HP: {defender.Health}/{defender.MaxHealth})");
        }

        private void EndBattle(CodingWarrior winner)
        {
            AddToLog($"{winner.Name} conquers the fight! (HP: {winner.Health}/{winner.MaxHealth})");
            isBattleInProgress = false;

            if (winner is RogerRipper)
                AddToLog("Bugs shattered!");
            else if (winner is RyenVizier)
                AddToLog("Fate controlled!");
            else if (winner is StarLord)
                AddToLog("Battle mastered!");
            else if (winner is PauCoder)
                AddToLog("Code dominates!");
        }


        private void AddToLog(string message)
        {
            battleLog.Add($"[{DateTime.Now:HH:mm:ss}] {message}");
        }
    }
}