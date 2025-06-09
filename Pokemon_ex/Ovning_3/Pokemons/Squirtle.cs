namespace Ovning_3.Pokemons
{
    using Ovning_3.Actions;
    using Abstract;

    internal class Squirtle() : ElementalPokemon(ElementType.Water)
    {
        public override bool Evolvable => throw new NotImplementedException();
    }
}