using Ovning_3.Utils;

namespace Ovning_3
{
    internal class FirePokemon(List<Attack<Fire>> attacks) : Pokemon(attacks, ElementType.Fire)
    {
        readonly List<Attack<Fire>> attacks = attacks;
     


        
 

        public override string Attack()
        {
            foreach (var item in Attacks)
            {
                //if (item.Type == ElementType.Fire)
                Console.WriteLine(item.Use(Level));
                //else Console.WriteLine($"cant use attack of type {item.Type}");
            }
            return "";
        }
    }
}