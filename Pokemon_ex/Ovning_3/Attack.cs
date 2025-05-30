namespace Ovning_3
{
    using System;
    using Utils;
    public class Attack<T>(T weapon) where T : Enum
    {
        public T Weapon { get; set; } = weapon;
        public string Use(int level)
        {  
            return $"{Weapon} hits with total power {BasePower.Get(Weapon) + level}!";
        }
    }
}