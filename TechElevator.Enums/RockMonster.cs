namespace TechElevator.Enums
{
    public class RockMonster : GameEnemy
    {
        public override string Name
        {
            get
            {
                return "Rock Monster";
            }
        }

        public override void Attack(int baseDamage, DamageType damageType)
        {
            switch (damageType)
            {
                case DamageType.Crushing:
                    HitPoints -= baseDamage * 2; // Rock Monsters are vulnerable to smashing
                    break;
                case DamageType.Fire:
                    // Rock monsters are immune to fire
                    break;
                default: // Whatever, just do the default
                    HitPoints -= baseDamage;
                    break;
            }
        }
    }
}
