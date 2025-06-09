namespace Ovning_3.Pokemons
{
    using Ovning_3;
    using Ovning_3.Actions;
    using Ovning_3.Pokemons.Abstract;
    using Utils;
    internal class Charmander() : ElementalPokemon(ElementType.Fire)
    {
        public override bool Evolvable => true;

        //private readonly string[] _evolveTier = ["Charmeleon", "Charizard"];
        public void Evolve()
        {
            string new_name = "Charmeleon";
            Level += 10;
            Evolve(new_name);
            //this = new Charmeleon(this);
        }
        private class Charmeleon() : Charmander()
        {
            public override bool Evolvable => true;


            private class Charizard() : Charmeleon {
                public override bool Evolvable => false;


            }
        }

    }
}