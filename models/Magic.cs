namespace CivRpgCharacterExample_20210617.models
{
    public class Magic : Ranged
    {
        public int MpCost { get; set; }

        public Magic(string name, int weight, int value, int damage, int maxDurability, int minRange, int maxRange, int mpCost)
                    : base(name, weight, value, damage, maxDurability, minRange, maxRange) {
            this.MpCost = mpCost;

        }
    }
}