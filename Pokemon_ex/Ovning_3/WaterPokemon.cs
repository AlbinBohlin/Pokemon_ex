namespace Ovning_3
{using Utils;
    internal class WaterPokemon(string name, int level, List<Attack> attacks) : Pokemon(name, level, attacks, ElementType.Water)
    {
        public override string Attack()
        {
            throw new NotImplementedException();
        }
    }
}