namespace TestPokemon
{
    using Ovning_3.Actions;
    using Ovning_3.Pokemons;
    using Ovning_3.Pokemons.Abstract;

    public class UtilTests
    {   


        [Fact]
        public void Test_InternaVisibleTo()
        {
            Pokemon internalPokemonClass = new Charmander() { Name="n",Level=1, Attacks = new List<Attack>()};

        }
    }
}
