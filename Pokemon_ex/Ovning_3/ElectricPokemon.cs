namespace Ovning_3
{
    
    using Utils;
    internal class ElectricPokemon(string name, int level, List<Attack> attacks) : Pokemon(name, level, attacks, ElementType.Electric)
    {
        public override string Attack()
        {
            throw new NotImplementedException();
        }
    }
}