namespace Ovning_3
{
    using Utils;
    internal class Attack
    {
        public string Name {  get; private set; }
        private readonly ElementType attackElement;
        public int BasePower { get; private set; }

        public Attack(string name, ElementType elementType, int basePower)
        {
            Name = name;
            attackElement = elementType;
            BasePower = basePower;
        }
    }
}