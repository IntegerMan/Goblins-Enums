namespace TechElevator.Enums
{
    public abstract class GameEnemy
    {
        /// <summary>
        /// Gets or sets the hit points an enemy has. Only settable by inheriting classes.
        /// </summary>
        public int HitPoints { get; protected set; } = 10;

        /// <summary>
        /// Gets the name of the enemy.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Attacks an enemy, potentially doing damage
        /// </summary>
        /// <param name="baseDamage">The unmodified damage to deal.</param>
        /// <param name="damageType">
        /// The type of damage to deal. Individual enemies may be more or less sensitive to specific types of damage.
        /// </param>
        public abstract void Attack(int baseDamage, DamageType damageType);
    }
}
