namespace TechElevator.Enums
{
    public class Goblin : GameEnemy
    {
        public override string Name
        {
            get
            {
                return "Goblin";
            }
        }

        public override void Attack(int baseDamage, DamageType damageType)
        {
            if (damageType == DamageType.Stab)
            {
                // Goblins are vulnerable to stabbing
                this.HitPoints -= baseDamage * 2;
            }
            else if (damageType == DamageType.ExistentialDread)
            {
                // Goblins immediately die when impacted by existential dread.
                this.HitPoints = 0;
            }
            else
            {
                this.HitPoints -= baseDamage;
            }
        }
    }
}
