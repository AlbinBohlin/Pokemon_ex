namespace Ovning_3
{
    using Ovning_3.Pokemons.Abstract;
    using Utils;
    internal class WaterPokemon( List<Attack> attacks) : Pokemon(attacks, ElementType.Water)
    {
        public override string Attack()
        {
            throw new NotImplementedException();
        }
    }
}