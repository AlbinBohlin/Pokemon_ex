using Ovning_3.Utils;

namespace Ovning_3
{
    internal class FirePokemon( List<Attack> attacks) : Pokemon( attacks, ElementType.Fire)
    {
        

        public override string Attack()
        {
            foreach (Attack item in Attacks)
            {
                if (item.Type == ElementType.Fire)
                Console.WriteLine(item.Use(Level));
                else Console.WriteLine($"cant use attack of type {item.Type}");
            }
            return "";
        }
    }
}