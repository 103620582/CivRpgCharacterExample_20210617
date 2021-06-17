namespace CivRpgCharacterExample_20210617.models
{
    public class Ranged : Weapon
    {
        public int MinRange { get; set; }
        public int MaxRange { get; set; }

        public Ranged(string name, int weight, int value, int damage, int maxDurability, int minRange, int maxRange)
                    : base(name, weight, value, damage, maxDurability) {
            
            this.MinRange = minRange;
            this.MinRange = maxRange;

        }
    }
}