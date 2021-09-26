using System;
using System.Collections.Generic;

namespace TechElevator.Enums
{
    public class Program
    {
        public static void Main()
        {
            // We have 3 different monsters, each with their own resistances
            GameEnemy[] enemies = new GameEnemy[] { new Goblin(), new Troll(), new RockMonster() }

            // Loop through each one and attack it
            foreach (GameEnemy enemy in enemies)
            {
                int baseDamage = 5;
                DamageType damageType = DamageType.Stab;

                enemy.Attack(baseDamage, damageType);
                Console.WriteLine($"You stab the {enemy.Name}. It now has {enemy.HitPoints} HP");
            }
        }
    }

    public enum DamageType
    {
        Stab,
        Crushing,
        Fire,
        ExistentialDread
    }

    public enum CardSuit
    {
        Spade,
        Club,
        Diamond,
        Heart,
        Joker
    }

    public enum BankTransactionType
    {
        Withdrawal,
        Deposits,
        Fine,
        Interest,
        Transfer
    }
}
