namespace Ovning_3
{
    using System;
    using Utils;
    public class Attack(string name, ElementType e, int basePower)
    {
        public string Name { get; private set; } = name;
        public ElementType Type { get; private set; } = e;
        public int BasePower { get; private set; } = basePower;

        public string Use(int level)
        {
            return $"{Name} hits with total power {BasePower + level}!";
        }
    }
}