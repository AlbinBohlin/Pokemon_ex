using Ovning_3.Utils;

namespace Ovning_3
{
    internal class FirePokemon(string name, int level, List<Attack> attacks) : Pokemon(name, level, attacks, ElementType.Fire)
    {
        

        public override string Attack()
        {
            foreach (Attack item in Attacks)
            {
                Console.WriteLine(item.Use(Level));
            }
            return "";
        }
    }
}