namespace Ovning_3.Pokemons
{
    using Ovning_3;
    using Ovning_3.Actions;
    using Ovning_3.Pokemons.Abstract;
    using Utils;
    internal class Charmander() : ElementalPokemon(ElementType.Fire), IEvolvable
    {
        //private readonly string[] _evolveTier = ["Charmeleon", "Charizard"];
        public void Evolve()
        {
            string new_name = "Charmeleon";
            Level += 10;
            Evolve(new_name);
            //this = new Charmeleon(this);
        }
        private class Charmeleon() : Charmander(), IEvolvable
        {
            public void Evolve(string newName)
            {
                throw new NotImplementedException();
            }
            private class Charizard() : Charmeleon { 
            
            }
        }

    }
}