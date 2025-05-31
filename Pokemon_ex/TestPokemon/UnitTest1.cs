namespace TestPokemon
{
    using Ovning_3;
    using Ovning_3.Pokemons.Abstract;

    public class UtilTests
    {   


        [Fact]
        public void Test_InternaVisibleTo()
        {
            Pokemon pokemon = new Charmander(new List<Attack>()) { Name="n",Level=1};

        }
    }
}
