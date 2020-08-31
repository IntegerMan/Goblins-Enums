namespace TechElevator.Enums
{
    public class Troll : GameEnemy
    {
        public override string Name
        {
            get
            {
                return "Troll";
            }
        }

        public override void Attack(int baseDamage, DamageType damageType)
        {
            // Trolls are only damaged by fire. All other damage types are ignored
            if (damageType == DamageType.Fire)
            {
                this.HitPoints -= baseDamage;
            }
        }
    }
}
